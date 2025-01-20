using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TCalculator.ViewModels;

public partial class CalculatorViewModel : ObservableObject
{
    [ObservableProperty]
    private decimal firstOperand;

    [ObservableProperty]
    private decimal secondOperand;

    [ObservableProperty]
    private decimal result;

    [RelayCommand]
    private void SumOperands() => SynchronizationContext.Current?.Send(_ => Result = FirstOperand + SecondOperand, null);

    [RelayCommand]
    private void SubtractOperands() => SynchronizationContext.Current?.Send(_ => Result = FirstOperand - SecondOperand, null);

    [RelayCommand]
    private void MultiplyOperands() => SynchronizationContext.Current?.Send(_ => Result = FirstOperand * SecondOperand, null);

    [RelayCommand]
    private void DivideOperands() => SynchronizationContext.Current?.Send(_ => Result = FirstOperand / SecondOperand, null);
}
