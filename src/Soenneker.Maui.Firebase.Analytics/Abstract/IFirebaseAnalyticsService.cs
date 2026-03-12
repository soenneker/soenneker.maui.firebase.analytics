using System.Collections.Generic;

namespace Soenneker.Maui.Firebase.Analytics.Abstract;

/// <summary>
/// Provides an interface for Firebase Analytics services to log events and manage user properties.
/// </summary>
public interface IFirebaseAnalyticsService
{
    /// <summary>
    /// Logs an event to Firebase Analytics.
    /// </summary>
    /// <param name="eventName">The name of the event to log. Should follow Firebase's event naming guidelines.</param>
    /// <param name="parameters">
    /// An optional dictionary of key-value pairs representing event parameters. 
    /// Use this to provide additional context for the event.
    /// </param>
    void LogEvent(string eventName, Dictionary<string, string>? parameters = null);

    /// <summary>
    /// Sets the user ID for Firebase Analytics.
    /// </summary>
    /// <param name="userId">
    /// A unique identifier for the user. This can be used to associate events with a specific user.
    /// Ensure compliance with privacy policies when using user identifiers.
    /// </param>
    void SetUserId(string userId);

    /// <summary>
    /// Assigns a custom user property in Firebase Analytics.
    /// </summary>
    /// <param name="propertyName">The name of the property to set. Should be alphanumeric and follow Firebase's guidelines.</param>
    /// <param name="propertyValue">The value associated with the property.</param>
    /// <remarks>
    /// User properties help categorize users based on custom attributes, improving analytics insights.
    /// </remarks>
    void SetUserProperty(string propertyName, string propertyValue);
}