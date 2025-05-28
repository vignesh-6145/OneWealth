using System.ComponentModel.DataAnnotations;

using FluentValidation;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using OneWealth.Business.DTO.Users;
using OneWealth.Business.Interfaces;

namespace OneWealth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;
        private readonly IValidator<UserRegistrationDto> _userValidator;

        public AuthController(ILogger<AuthController> logger, IAuthService authService, IValidator<UserRegistrationDto> validator)
        {
            _logger = logger;
            _authService = authService;
            _userValidator = validator;
        }

        [HttpPost("register")]
        [ProducesResponseType<Guid>(200)]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userInfo)
        {
            var validationResult = await _userValidator.ValidateAsync(userInfo).ConfigureAwait(false);
            Console.WriteLine(validationResult);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToDictionary());
            }
            Guid userId;
            try
            {
                userId = await _authService.RegisterUser(userInfo).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Something went wrong while registering the user {UserName}", userInfo?.UserName);
                return StatusCode(500, ex.Message);
            }
            
            return userId.Equals(Guid.Empty) ? BadRequest($"Failed to insert {userInfo?.UserName}") : Ok($"User created with Id {userId}");
        }
    }
}
