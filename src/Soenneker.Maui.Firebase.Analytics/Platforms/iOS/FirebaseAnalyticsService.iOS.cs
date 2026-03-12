using System.Collections.Generic;
using Foundation;
using Soenneker.Maui.Firebase.Analytics.Abstract;

namespace Soenneker.Maui.Firebase.Analytics.Platforms.iOS;

public class FirebaseAnalyticsService : IFirebaseAnalyticsService
{
    public void LogEvent(string eventName, Dictionary<string, string>? parameters = null)
    {
        if (parameters != null)
        {
            var keys = new NSString[parameters.Count];
            var values = new NSObject[parameters.Count];

            var i = 0;
            foreach (KeyValuePair<string, string> param in parameters)
            {
                keys[i] = new NSString(param.Key);
                values[i] = new NSString(param.Value);
                i++;
            }

            var dict = new NSDictionary<NSString, NSObject>(keys, values);
            global::Firebase.Analytics.Analytics.LogEvent(eventName, dict);
        }
        else
        {
            var emptyDict = new NSDictionary<NSString, NSObject>();
            global::Firebase.Analytics.Analytics.LogEvent(eventName, emptyDict);
        }
    }

    public void SetUserId(string userId)
    {
        global::Firebase.Analytics.Analytics.SetUserId(userId);
    }

    public void SetUserProperty(string propertyName, string propertyValue)
    {
        global::Firebase.Analytics.Analytics.SetUserProperty(propertyName, propertyValue);
    }
}
