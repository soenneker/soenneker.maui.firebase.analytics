using Microsoft.Extensions.DependencyInjection;
using Soenneker.Maui.Firebase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
