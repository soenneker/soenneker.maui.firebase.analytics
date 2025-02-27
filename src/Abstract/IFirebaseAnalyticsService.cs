using System.Collections.Generic;

namespace Soenneker.Maui.Firebase.Services;

public interface IFirebaseAnalyticsService
{
    void LogEvent(string eventName, Dictionary<string, string>? parameters = null);
    void SetUserId(string userId);
    void SetUserProperty(string propertyName, string propertyValue);
}
