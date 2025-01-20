using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace TCalculator.Reqnroll.FlaUI.Drivers;

public class ApplicationDriver
{
    private AutomationBase Automation { get; } = new UIA3Automation();

    private Application? application;

    public Application Application => application ??= StartApplication();

    public Window MainWindow => Application.GetMainWindow(Automation);

    private static Application StartApplication()
    {
        var app = Application.LaunchStoreApp("c08bc58a-61ca-4cee-a7ff-02963b7b1d8d_nxj8xnbr902qw!App");
        app.WaitWhileMainHandleIsMissing();
        return app;
    }
}
