using Microsoft.Extensions.DependencyInjection;
namespace OneWealth.Presentation;
public static class GlobalDependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services){
        return services;
    }
}
