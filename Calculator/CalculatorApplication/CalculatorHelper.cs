namespace Calculator
{
    public class CalculatorHelper
    {
        public CalculatorHelper()
        {
            State = CalculatorStates.Clear;
        }

        public void HandleButton1()
        {
            Operand1 = 1;
            DisplayText = "1";
            State = CalculatorStates.EnteringOperand1;
        }

        public static int Operand1 { get; set; }

        public static string DisplayText { get; set; }

        public static CalculatorStates State { get; set; }

        public void HandleButtonPlus()
        {
            DisplayText = "1 +";
        }
    }
}