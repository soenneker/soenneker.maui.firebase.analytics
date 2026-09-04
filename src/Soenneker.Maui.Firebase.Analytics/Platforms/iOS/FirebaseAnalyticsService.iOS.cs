using System.Collections.Generic;
using Foundation;
using Soenneker.Maui.Firebase.Analytics.Abstract;

namespace Soenneker.Maui.Firebase.Analytics.Platforms.iOS;

/// <inheritdoc cref="IFirebaseAnalyticsService" />
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

            var dictionary = new NSDictionary<NSString, NSObject>(keys, values);

            try
            {
                global::Firebase.Analytics.Analytics.LogEvent(eventName, dictionary);
            }
            finally
            {
                dictionary.Dispose();

                foreach (NSString key in keys)
                    key.Dispose();

                foreach (NSObject value in values)
                    value.Dispose();
            }
        }
        else
        {
            using var emptyDict = new NSDictionary<NSString, NSObject>();
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
