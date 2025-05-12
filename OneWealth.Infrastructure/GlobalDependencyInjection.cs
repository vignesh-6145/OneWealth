using Microsoft.Extensions.DependencyInjection;

namespace OneWealth.Infrastructure;

public static class GlobalDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services){

        var assembly = typeof(GlobalDependencyInjection).Assembly;

        return services;
    }
}
