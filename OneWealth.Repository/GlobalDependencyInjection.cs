using System;

using Microsoft.Extensions.DependencyInjection;

using OneWealth.Repository.Interfaces;
using OneWealth.Repository.Repositories;

namespace OneWealth.Repository;

public static class GlobalDependencyInjection
{
    public static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
