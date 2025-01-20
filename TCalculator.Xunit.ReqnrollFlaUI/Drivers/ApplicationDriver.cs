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
        // HACK:
        var dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent;
        var app = Application.Launch(@$"{dir}\TCalculator.WPF\bin\Debug\net8.0-windows\TCalculator.WPF.exe");
        app.WaitWhileMainHandleIsMissing();
        return app;
    }
}
