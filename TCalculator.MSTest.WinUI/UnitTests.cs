using CommunityToolkit.Mvvm.Input;

using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;

using Shouldly;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using TCalculator.ViewModels;
using TCalculator.WinUI;

namespace TCalculator.MSTest.WinUI
{
    [TestClass]
    public class UnitTest1
    {
        // Use the UITestMethod attribute for tests that need to run on the UI thread.
        [UITestMethod]
        public void TestMethod2()
        {
            var vm = new CalculatorViewModel
            {
                FirstOperand = "10",
                SecondOperand = "20"
            };
            vm.SumOperandsCommand.Execute(null); // Executes on UI thread
            
            vm.Result.ShouldBe("30"); // Fails, because MSTest does not provide async support :V
        }
    }
}
