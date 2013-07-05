namespace Calculator
{
    public class CalculatorHelper
    {
        public void HandleButton1()
        {
            Operand1 = 1;
            DisplayText = "1";
        }

        public static int Operand1 { get; set; }

        public static string DisplayText { get; set; }

        public void HandleButtonPlus()
        {
            DisplayText = "1 +";
        }
    }
}