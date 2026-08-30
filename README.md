# Soenneker.Maui.Firebase.Analytics
[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.analytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.analytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.analytics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.analytics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.analytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.analytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.analytics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.analytics/actions/workflows/codeql.yml)

Provides a small Android and iOS abstraction for logging Firebase Analytics events and setting user attributes from a .NET MAUI app.

## Installation

```bash
dotnet add package Soenneker.Maui.Firebase.Analytics
```

Configure the native Firebase app first with `Soenneker.Maui.Firebase`, including the platform's `google-services.json` or `GoogleService-Info.plist`.

## Registration

Register the analytics service in `MauiProgram.CreateMauiApp`:

```csharp
using Soenneker.Maui.Firebase.Analytics.Registrars;
using Soenneker.Maui.Firebase.Dtos;
using Soenneker.Maui.Firebase.Registrars;

builder.UseFirebase(new FirebaseConfig())
       .Build();

builder.Services.AddFirebaseAnalyticsServiceAsSingleton();
```

The service is registered only for Android and iOS targets.

## Usage

Inject `IFirebaseAnalyticsService` into a page, view model, or application service:

```csharp
using Soenneker.Maui.Firebase.Analytics.Abstract;

public sealed class CheckoutTracker(IFirebaseAnalyticsService analytics)
{
    public void Completed(string orderType)
    {
        analytics.LogEvent("checkout_completed", new Dictionary<string, string>
        {
            ["order_type"] = orderType
        });
    }

    public void IdentifySignedInUser(string internalUserId)
    {
        analytics.SetUserId(internalUserId);
        analytics.SetUserProperty("account_tier", "pro");
    }
}
```

Event parameters in this abstraction are string values. Event names, parameter names, and user-property names must satisfy Firebase Analytics naming and quota rules; invalid data is handled by the native SDK.

Use an opaque application identifier for `SetUserId`. Do not send names, email addresses, or other personally identifiable information, and obtain any consent required by the app's privacy policy before collecting analytics.
