using Soenneker.Tests.HostedUnit;

namespace Soenneker.Maui.Firebase.Analytics.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FirebaseAnalyticsUtilTests : HostedUnitTest
{

    public FirebaseAnalyticsUtilTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
