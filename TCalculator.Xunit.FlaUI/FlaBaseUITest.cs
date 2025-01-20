using FlaUI.Core;
using FlaUI.UIA3;

namespace TCalculator.Xunit.FlaUI;

public class FlaBaseUITest
{
    protected AutomationBase Automation { get; } = new UIA3Automation();

    protected Application StartApplication()
    {
        var app = Application.LaunchStoreApp("c08bc58a-61ca-4cee-a7ff-02963b7b1d8d_nxj8xnbr902qw!App");
        app.WaitWhileMainHandleIsMissing();
        return app;
    }
}
