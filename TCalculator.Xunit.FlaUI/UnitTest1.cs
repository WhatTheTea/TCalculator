using FlaUI.Core.AutomationElements;

namespace TCalculator.Xunit.FlaUI;

public class UnitTest1 : FlaBaseUITest
{
    [Fact]
    public void AppStarts()
    {
        var app = StartApplication();

        app.IsStoreApp.ShouldBeTrue();
        var mainWindow = app.GetMainWindow(Automation);

        mainWindow.ShouldNotBeNull();
        app.Close();
    }

    [Fact]
    public async Task SumIsValid()
    {
        var app = StartApplication();
        var mainWindow = app.GetMainWindow(Automation);

        mainWindow.FindFirstDescendant("op1").AsTextBox().Text = "3";
        mainWindow.FindFirstDescendant("op2").AsTextBox().Text = "2";

        var button = mainWindow.FindFirstDescendant("plus").AsButton();
        button.Focus(); // trigger lost focus event
        button.Click();


        mainWindow.FindFirstDescendant("res").AsTextBox().Text.ShouldBe("5");
        app.Close();
    }
}