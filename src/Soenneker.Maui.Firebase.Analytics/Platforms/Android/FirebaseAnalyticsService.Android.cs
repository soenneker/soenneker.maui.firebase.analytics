using System.Collections.Generic;
using Android.App;
using Android.OS;
using Firebase.Analytics;
using Soenneker.Maui.Firebase.Analytics.Abstract;

namespace Soenneker.Maui.Firebase.Analytics.Platforms.Android;

public class FirebaseAnalyticsService : IFirebaseAnalyticsService
{
    private readonly FirebaseAnalytics _firebaseAnalytics;

    public FirebaseAnalyticsService()
    {
        _firebaseAnalytics = FirebaseAnalytics.GetInstance(Application.Context);
    }

    public void LogEvent(string eventName, Dictionary<string, string>? parameters = null)
    {
        var bundle = new Bundle();
        if (parameters != null)
        {
            foreach (KeyValuePair<string, string> param in parameters)
            {
                bundle.PutString(param.Key, param.Value);
            }
        }
        _firebaseAnalytics.LogEvent(eventName, bundle);
    }

    public void SetUserId(string userId)
    {
        _firebaseAnalytics.SetUserId(userId);
    }

    public void SetUserProperty(string propertyName, string propertyValue)
    {
        _firebaseAnalytics.SetUserProperty(propertyName, propertyValue);
    }
}
