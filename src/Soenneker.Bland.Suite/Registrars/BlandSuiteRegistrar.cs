using Microsoft.Extensions.DependencyInjection;
using Soenneker.Bland.Calls.Registrars;

namespace Soenneker.Bland.Suite.Registrars;

/// <summary>
/// Registers all utilities included in the Bland suite package.
/// </summary>
public static class BlandSuiteRegistrar
{
    /// <summary>
    /// Adds the included Bland Calls utility as a singleton service.
    /// </summary>
    /// <param name="services">Service collection that receives the registrations.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddBlandSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds the included Bland Calls utility as a scoped service.
    /// </summary>
    /// <param name="services">Service collection that receives the registrations.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddBlandSuiteAsScoped(this IServiceCollection services)
    {
        services.AddBlandCallUtilAsScoped();

        return services;
    }
}
