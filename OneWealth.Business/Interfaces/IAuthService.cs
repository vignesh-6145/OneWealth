using System;

using OneWealth.Business.DTO.Users;

namespace OneWealth.Business.Interfaces;

public interface IAuthService
{
    public Task<Guid> RegisterUser(UserRegistrationDto userInfo);
}
