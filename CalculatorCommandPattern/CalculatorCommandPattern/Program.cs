using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure calculator and its buttons
            Calculator calculator = new Calculator(5);
            calculator.ConfigureButton(0, new AddCommand());
            calculator.ConfigureButton(1, new SubCommand());
            calculator.ConfigureButton(2, new MulCommand());
            calculator.ConfigureButton(3, new DivCommand());
            calculator.ConfigureButton(4, new EqualsCommand());

            // Create a new user who uses the calculator configured above
            User user = new User(calculator);

            // The user enters 5 + 7 on the calculator and calculates this expression
            user.PushValueButton(5);
            user.PushCalcButton(0);
            user.PushValueButton(7);
            user.PushCalcButton(4);

            // The user regrets the "equals" action and presses undo button. The expression is not "5 + 7" instead of "12"
            user.PushUndoButton();

            // The user adds " + 2" to the expression and presses the equals button again
            user.PushCalcButton(0);
            user.PushValueButton(2);
            user.PushCalcButton(4);

            // The expression is now "14" and the user adds " - 5" to the expression and presses equals on the calculator one last time
            user.PushCalcButton(1);
            user.PushValueButton(5);
            user.PushCalcButton(4);
        }
    }
}
