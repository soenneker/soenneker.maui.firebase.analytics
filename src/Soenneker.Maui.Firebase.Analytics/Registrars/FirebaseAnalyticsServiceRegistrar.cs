using Microsoft.Extensions.DependencyInjection;
using Soenneker.Maui.Firebase.Analytics.Abstract;

#if ANDROID
using Soenneker.Maui.Firebase.Analytics.Platforms.Android;
#endif

#if IOS
using Soenneker.Maui.Firebase.Analytics.Platforms.iOS;
#endif
namespace Soenneker.Maui.Firebase.Analytics.Registrars;

    /// <summary>
    /// Represents the firebase analytics service registrar.
    /// </summary>
    public static class FirebaseAnalyticsServiceRegistrar
    {

        /// <summary>
        /// Adds firebase analytics service as singleton.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <returns>The result of the operation.</returns>
        public static IServiceCollection AddFirebaseAnalyticsServiceAsSingleton(this IServiceCollection services)
        {
#if ANDROID
    services.AddSingleton<IFirebaseAnalyticsService, FirebaseAnalyticsService>();
#endif
#if IOS
    services.AddSingleton<IFirebaseAnalyticsService, FirebaseAnalyticsService>();
#endif
            return services;
        }
        
    }
