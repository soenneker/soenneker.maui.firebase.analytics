using Microsoft.Extensions.DependencyInjection;
using Soenneker.Maui.Firebase.Analytics.Abstract;

#if ANDROID
using Soenneker.Maui.Firebase.Analytics.Platforms.Android;
#endif

#if IOS
using Soenneker.Maui.Firebase.Analytics.Platforms.iOS;
#endif
namespace Soenneker.Maui.Firebase.Analytics.Registrars;

    public static class FirebaseAnalyticsServiceRegistrar
    {

            public static IServiceCollection AddFirebaseAnalytics(this IServiceCollection services)
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
