using Microsoft.Extensions.DependencyInjection;
using Soenneker.Bland.Calls.Registrars;

namespace Soenneker.Bland.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Bland.ai
/// </summary>
public static class BlandSuiteRegistrar
{
    /// <summary>
    /// Adds bland suite as singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddBlandSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds bland suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddBlandSuiteAsScoped(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsScoped();

        return services;
    }
}