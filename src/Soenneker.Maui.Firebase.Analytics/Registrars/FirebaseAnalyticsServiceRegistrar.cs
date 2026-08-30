using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Maui.Firebase.Analytics.Abstract;

#if ANDROID
using Soenneker.Maui.Firebase.Analytics.Platforms.Android;
#endif

#if IOS
using Soenneker.Maui.Firebase.Analytics.Platforms.iOS;
#endif

namespace Soenneker.Maui.Firebase.Analytics.Registrars;

/// <summary>
/// Registers Firebase Analytics services.
/// </summary>
public static class FirebaseAnalyticsServiceRegistrar
{
    /// <summary>
    /// Registers the Firebase Analytics service with a singleton lifetime.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddFirebaseAnalyticsServiceAsSingleton(this IServiceCollection services)
    {
#if ANDROID
        services.TryAddSingleton<IFirebaseAnalyticsService, FirebaseAnalyticsService>();
#endif
#if IOS
        services.TryAddSingleton<IFirebaseAnalyticsService, FirebaseAnalyticsService>();
#endif
        return services;
    }
}
