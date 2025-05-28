using System;

using AutoMapper;

using Microsoft.Extensions.Logging;

using OneWealth.Business.DTO.Users;
using OneWealth.Business.Exceptions;
using OneWealth.Business.Interfaces;
using OneWealth.Repository.DataModels;
using OneWealth.Repository.Interfaces;

namespace OneWealth.Business.Services;

public class AuthService : IAuthService
{
    private readonly ILogger<AuthService> _logger;
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly ICryptoService _cryptoService;

    public AuthService(ILogger<AuthService> logger, IUserRepository userRepository, IMapper mapper, ICryptoService cryptoService)
    {
        _logger = logger;
        _userRepository = userRepository;
        _mapper = mapper;
        _cryptoService = cryptoService;
    }
    

    public async Task<Guid> RegisterUser(UserRegistrationDto userInfo)
    {
        if (userInfo == null)
            _logger.LogInformation("RegisterUser Service called with null"); //TODO : change it to custom exception
        _logger.LogInformation("Registration Process Started for {UserName}", userInfo?.UserName);

        var transaction = await _userRepository.GetTransactionAsync().ConfigureAwait(false);
        try
        {
            var users = _userRepository.GetUsers();
            var isPINotUnique = users.Aggregate((isUserNameNotUnique: false, isEmailNotUnique: false, isPhoneNotUnique: false), (src, seed) =>
            (
                isUserNameNotUnique: src.isUserNameNotUnique || seed.UserName == userInfo?.UserName,
                isEmailNotUnique: src.isEmailNotUnique || seed.Email == userInfo?.Email,
                isPhoneNotUnique: src.isPhoneNotUnique || seed.Mobile == userInfo?.Mobile
            ));

            if (isPINotUnique.isUserNameNotUnique)
                throw new UserNameAlreadyExistsException(userInfo?.UserName ?? "");
            if (isPINotUnique.isEmailNotUnique)
                throw new EmailAlreadyInUseException(userInfo?.Email ?? "");
            if (isPINotUnique.isPhoneNotUnique)
                throw new MobileAlreadInUseException(userInfo?.Mobile ?? "");

            var user = _mapper.Map<User>(userInfo);
            user.Password = _cryptoService.SaltHash(user.Password ?? "");
            _userRepository.AddUser(user);
            await _userRepository.SaveChangesAsync().ConfigureAwait(false);
            var userId = user.Id;
            _logger.LogInformation("Inserted user returned {UserID}", userId);

            var userInformation = _mapper.Map<UserInformation>(userInfo);
            userInformation.Id = userId;
            _userRepository.AddUserInformation(userInformation);
            await _userRepository.SaveChangesAsync().ConfigureAwait(false);
            _logger.LogInformation("Inserted UserInformation for {UserName}", user.UserName);

            var userFinancialProfile = _mapper.Map<UserFinancialProfile>(userInfo);
            userFinancialProfile.Id = userId;
            _userRepository.AddUserFinancialProfile(userFinancialProfile);
            await _userRepository.SaveChangesAsync().ConfigureAwait(false);
            _logger.LogInformation("Inserted UserFinancialProfile for {UserName}", user.UserName);

            await transaction.CommitAsync().ConfigureAwait(false);
            return user.Id;
            //TODO: Email & mobile authentication
        }
        catch (Exception e)  when (e is UserNameAlreadyExistsException || e is EmailAlreadyInUseException || e is MobileAlreadInUseException){
            throw ;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync().ConfigureAwait(false);
            _logger.LogInformation("Failed while inserting user Rolling back for {UserName}", userInfo?.UserName);
            _logger.LogError(ex, "Something went wrong while registering user {UserName}", userInfo?.UserName);
            return Guid.Empty;

        }
    }

}
