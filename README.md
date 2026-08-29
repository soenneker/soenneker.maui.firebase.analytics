[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.analytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.analytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.analytics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.analytics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.analytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.analytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.analytics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.analytics/actions/workflows/codeql.yml)

# Soenneker.Maui.Firebase.Analytics

Provides an interface for Firebase Analytics services to log events and manage user properties.

## Install

```bash
dotnet add package Soenneker.Maui.Firebase.Analytics
```

## Quick start

```csharp
using Soenneker.Maui.Firebase.Analytics.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddFirebaseAnalyticsServiceAsSingleton();
```

Registers Firebase Analytics Service with a singleton lifetime.

## What you get

- `IFirebaseAnalyticsService` — Provides an interface for Firebase Analytics services to log events and manage user properties.
- `FirebaseAnalyticsServiceRegistrar` — Represents the firebase analytics service registrar.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IFirebaseAnalyticsService.LogEvent(eventName, parameters)` | Logs an event to Firebase Analytics. | Returns no value; the requested change is complete when the method returns. |
| `IFirebaseAnalyticsService.SetUserId(userId)` | Sets the user ID for Firebase Analytics. | Returns no value; the requested change is complete when the method returns. |
| `IFirebaseAnalyticsService.SetUserProperty(propertyName, propertyValue)` | Assigns a custom user property in Firebase Analytics. | User properties help categorize users based on custom attributes, improving analytics insights. |
| `FirebaseAnalyticsServiceRegistrar.AddFirebaseAnalyticsServiceAsSingleton(services)` | Registers Firebase Analytics Service with a singleton lifetime. | The same service collection, so additional registrations can be chained. |

## Important behavior

- `IFirebaseAnalyticsService.SetUserProperty(propertyName, propertyValue)`: User properties help categorize users based on custom attributes, improving analytics insights.
