using System;

using Microsoft.Extensions.DependencyInjection;

using OneWealth.Business.Interfaces;
using OneWealth.Business.Services;


namespace OneWealth.Business;

public static class GlobalDependencyInjection
{
    public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ICryptoService, CryptoSerice>();
        return services;
    }

}
