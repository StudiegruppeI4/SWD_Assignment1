using System;
using System.Collections.Generic;

namespace CalculatorCommandPattern
{
    public class Calculator : ICalculator
    {
        private List<CalcCommand> _calcButtons;
        private string _expression;
        private int _lastBtnPushed;

        public Calculator(int size)
        {
            _calcButtons = new List<CalcCommand>(size);
            _expression = "";
        }

        // Configures a button on the calculator. The calculator is initialized with a given capacity for buttons.
        // The buttons must be inserted within this capacity
        public void ConfigureButton(int button, CalcCommand command)
        {
            if (button >= 0 && button < _calcButtons.Capacity)
                _calcButtons.Insert(button, command);
            else
                Console.WriteLine("That's not a valid Calculator button slot!");
        }

        // Pushes one of the calculators configured expression buttons, adding it to the expression
        public void CalcButtonPushed(int button)
        {
            if (button >= 0 && button <= _calcButtons.Capacity)
            {
                _calcButtons[button].Execute(ref _expression);
                _lastBtnPushed = button;
            }
            else
                Console.WriteLine("That's not a valid Calculator button slot!");
        }

        // Pushes one of the calculators value buttons between 0 and 9, adding it to the expression
        public void ValueButtonPushed(int button)
        {
            if (button >= 0 && button <= 9)
                _expression += button;
            else
                Console.WriteLine("That's not a valid Calculator value entry!");
        }

        // Undos the latest action performed by the calculator, changing the expression
        public void UndoButtonPushed()
        {
            _expression = _calcButtons[_lastBtnPushed].Undo();
        }
    }
}