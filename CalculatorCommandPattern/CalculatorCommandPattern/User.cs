namespace CalculatorCommandPattern
{
    public class User
    {
        private ICalculator _calc;

        public User(ICalculator calc)
        {
            _calc = calc;
        }

        // The user presses a configured expression button on the calculator interface
        public void PushCalcButton(int button)
        {
            _calc.CalcButtonPushed(button);
        }

        // The user presses a value button between 0 and 9 on the calculator interface
        public void PushValueButton(int button)
        {
            _calc.ValueButtonPushed(button);
        }

        // The user undos the latest action on the calculator interface
        public void PushUndoButton()
        {
            _calc.UndoButtonPushed();
        }
    }
}