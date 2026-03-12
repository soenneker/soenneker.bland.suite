using Microsoft.Extensions.DependencyInjection;
using Soenneker.Bland.Calls.Registrars;

namespace Soenneker.Bland.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Bland.ai
/// </summary>
public static class BlandSuiteRegistrar
{
    public static IServiceCollection AddBlandSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddBlandSuiteAsScoped(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsScoped();

        return services;
    }
}