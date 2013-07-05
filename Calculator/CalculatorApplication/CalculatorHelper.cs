namespace Calculator
{
    public class CalculatorHelper
    {
        public CalculatorHelper()
        {
            State = CalculatorStates.Clear;
            DisplayText = "";
        }

        public void HandleButton1()
        {
            if (State == CalculatorStates.Clear)
            {
                State = CalculatorStates.EnteringOperand1;
                Operand1 = 1;
            }
            if (State == CalculatorStates.OperatorEntered)
            {
                State = CalculatorStates.EnteringOperand2;
                Operand2 = 1;
            }
            SetDisplayText();
        }

        private static void SetDisplayText()
        {
            if (State == CalculatorStates.EnteringOperand1)
            {
                DisplayText = "1";
            }
            if (State == CalculatorStates.EnteringOperand2)
            {
                DisplayText = "1 + 1";
            }
            if (State == CalculatorStates.OperatorEntered)
            {
                DisplayText = "1 +";
            }
        }

        public static int Operand1 { get; set; }

        public static string DisplayText { get; set; }

        public static CalculatorStates State { get; set; }

        public static int Operand2 { get; set; }

        public void HandleButtonPlus()
        {
            State = CalculatorStates.OperatorEntered;
            SetDisplayText();
        }
    }
}