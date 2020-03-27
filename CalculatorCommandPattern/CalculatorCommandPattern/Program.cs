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
            Calculator calculator = new Calculator(5);
            calculator.ConfigureButton(0, new AddCommand());
            calculator.ConfigureButton(1, new SubCommand());
            calculator.ConfigureButton(2, new MulCommand());
            calculator.ConfigureButton(3, new DivCommand());
            calculator.ConfigureButton(4, new EqualsCommand());

            User user = new User(calculator);
            user.PushValueButton(5);
            user.PushCalcButton(0);
            user.PushValueButton(7);
            user.PushCalcButton(4);
        }
    }
}
