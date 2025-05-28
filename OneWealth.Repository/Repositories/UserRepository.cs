using System;
using System.Numerics;

using Microsoft.Extensions.Logging;

using OneWealth.Repository.Data;
using OneWealth.Repository.DataModels;
using OneWealth.Repository.Interfaces;

namespace OneWealth.Repository.Repositories;

public class UserRepository : CoreRepository, IUserRepository
{
    public UserRepository(ILogger<UserRepository> logger, OneWealthContext context) : base(logger, context)
    {
    }

    public Guid AddUser(User userInfo)
    {
        _context.Users.Add(userInfo);
        return userInfo?.Id ?? Guid.Empty;
    }
    public void AddUserInformation(UserInformation userInfo)
    {
        _context.UserInformations.Add(userInfo);
    }
    public void AddUserFinancialProfile(UserFinancialProfile userFinancialProfile)
    {
        _context.UserFinancialProfiles.Add(userFinancialProfile);
    }
    public IEnumerable<User> GetUsers()
    {
        return _context.Users;
    }

}
