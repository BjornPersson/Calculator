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
            if (State == CalculatorStates.Clear)
            {
                State = CalculatorStates.EnteringOperand1;
            }
            if (State == CalculatorStates.OperatorEntered)
            {
                State = CalculatorStates.EnteringOperand2;
            }
            Operand1 = 1;
            DisplayText = "1";
        }

        public static int Operand1 { get; set; }

        public static string DisplayText { get; set; }

        public static CalculatorStates State { get; set; }

        public void HandleButtonPlus()
        {
            State = CalculatorStates.OperatorEntered;
            DisplayText = "1 +";
        }
    }
}