using System;
using System.Collections.Generic;

namespace CalculatorCommandPattern
{
    public class Calculator : ICalculator
    {
        private List<CalcCommand> _calcButtons;
        private string _expression;

        public Calculator(int size)
        {
            _calcButtons = new List<CalcCommand>(size);
            _expression = "";
        }

        public void ConfigureButton(int button, CalcCommand command)
        {
            if (button >= 0 && button < _calcButtons.Capacity)
                _calcButtons.Insert(button, command);
            else
                Console.WriteLine("That's not a valid Calculator button slot!");
        }

        public void CalcButtonPushed(int button)
        {
            if (button >= 0 && button <= _calcButtons.Capacity)
                _calcButtons[button].Execute(ref _expression);
            else
                Console.WriteLine("That's not a valid Calculator button slot!");
        }

        public void ValueButtonPushed(int button)
        {
            if (button >= 0 && button <= 9)
                _expression += button;
            else
                Console.WriteLine("That's not a valid Calculator value entry!");
        }
    }
}