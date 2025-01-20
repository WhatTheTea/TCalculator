using FlaUI.Core.AutomationElements;

using Shouldly;

using TCalculator.Reqnroll.FlaUI.Drivers;

namespace TCalculator.Reqnroll.FlaUI.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions(ApplicationDriver appDriver)
{
    private decimal op1 = 0;
    private decimal op2 = 0;

    [Given("the first number is {int}")]
    public void GivenTheFirstNumberIs(int number)
    {
        op1 = number;
        appDriver.MainWindow.FindFirstDescendant("op1").AsTextBox().Text = number.ToString();
    }

    [Given("the second number is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
        op2 = number;
        appDriver.MainWindow.FindFirstDescendant("op2").AsTextBox().Text = number.ToString();
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        var button = appDriver.MainWindow.FindFirstDescendant("plus").AsButton();
        button.Focus(); // trigger lost focus event
        button.Click();
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        appDriver.MainWindow.FindFirstDescendant("res").AsTextBox().Text.ShouldBe((op1+op2).ToString());
        appDriver.Application.Close();
    }
}
