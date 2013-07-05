using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        private CalculatorHelper _calculatorHelper;

        [TestMethod]
        public void HandleButton1Test()
        {
            _calculatorHelper = new CalculatorHelper();
            _calculatorHelper.HandleButton1();
            Assert.AreEqual(1, CalculatorHelper.Operand1);
        }

        [TestMethod]
        public void DisplayShows1Test()
        {
            _calculatorHelper = new CalculatorHelper();
            _calculatorHelper.HandleButton1();
            Assert.AreEqual("1", CalculatorHelper.DisplayText);
        }
    }
}
