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

        [TestMethod]
        public void HandleButtonPlusTest()
        {
            _calculatorHelper = new CalculatorHelper();
            _calculatorHelper.HandleButton1();
            _calculatorHelper.HandleButtonPlus();
            Assert.AreEqual("1 +", CalculatorHelper.DisplayText);
        }
        
        [TestMethod]
        public void StateIsClearAtStartUpTest()
        {
            _calculatorHelper = new CalculatorHelper();
            Assert.AreEqual(CalculatorStates.Clear, CalculatorHelper.State);
        }

        [TestMethod]
        public void StateIsEnteringOperand1Test()
        {
            _calculatorHelper = new CalculatorHelper();
            _calculatorHelper.HandleButton1();
            Assert.AreEqual(CalculatorStates.EnteringOperand1, CalculatorHelper.State);
        }

        [TestMethod]
        public void StateIsEnteringOperand2Test()
        {
            _calculatorHelper = new CalculatorHelper();

            // 1 + 1
            _calculatorHelper.HandleButton1();
            _calculatorHelper.HandleButtonPlus();
            _calculatorHelper.HandleButton1();
            Assert.AreEqual(CalculatorStates.EnteringOperand2, CalculatorHelper.State);
        }

    }
}
