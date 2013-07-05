using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorHelper.HandleButton1();
            Assert.AreEqual(1, CalculatorHelper.Operand1);
        }
    }

    public class CalculatorHelper
    {
        public static void HandleButton1()
        {
            Operand1 = 1;
        }

        public static int Operand1 { get; set; }
    }
}
