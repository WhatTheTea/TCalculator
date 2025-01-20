using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TCalculator.ViewModels;

public partial class CalculatorViewModel : ObservableObject
{
    private decimal firstOperand;
    private decimal secondOperand;

    public string FirstOperand
    {
        get => firstOperand.ToString();
        set => firstOperand = decimal.Parse(value);
    }

    public string SecondOperand
    {
        get => secondOperand.ToString();
        set => secondOperand = decimal.Parse(value);
    }

    [ObservableProperty]
    private string result = string.Empty;

    [RelayCommand]
    private void SumOperands() => SynchronizationContext.Current?.Post(_ => Result = (firstOperand + secondOperand).ToString(), null);

    [RelayCommand]
    private void SubtractOperands() => SynchronizationContext.Current?.Post(_ => Result = (firstOperand - secondOperand).ToString(), null);

    [RelayCommand]
    private void MultiplyOperands() => SynchronizationContext.Current?.Post(_ => Result = (firstOperand * secondOperand).ToString(), null);

    [RelayCommand]
    private void DivideOperands() => SynchronizationContext.Current?.Post(_ => Result = (firstOperand / secondOperand).ToString(), null);
}
