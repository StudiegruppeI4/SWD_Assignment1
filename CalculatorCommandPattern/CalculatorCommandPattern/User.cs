namespace CalculatorCommandPattern
{
    public class User
    {
        private ICalculator _calc;

        public User(ICalculator calc)
        {
            _calc = calc;
        }

        public void PushCalcButton(int button)
        {
            _calc.CalcButtonPushed(button);
        }

        public void PushValueButton(int button)
        {
            _calc.ValueButtonPushed(button);
        }
    }
}