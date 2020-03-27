using System;
using System.Runtime.Remoting.Messaging;
using Z.Expressions;

namespace CalculatorCommandPattern
{
    public class EqualsCommand : CalcCommand
    {
        public void Execute(ref string expression)
        {
            Previous = expression;
            int result = Eval.Execute<int>(expression);
            expression = result.ToString();
            Console.WriteLine($"The result of {Previous} is {expression}");
        }

        public string Undo()
        {
            return Previous;
        }

        public string Previous { get; set; }
    }
}