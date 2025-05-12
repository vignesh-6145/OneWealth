using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace OneWealth.Application;

public static class GlobalDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services){

        var assembly = typeof(GlobalDependencyInjection).Assembly;

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
