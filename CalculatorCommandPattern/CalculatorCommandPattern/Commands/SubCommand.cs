﻿namespace CalculatorCommandPattern
{
    public class SubCommand : CalcCommand
    {
        public void Execute(ref string expression)
        {
            Previous = expression;
            expression += "-";
        }

        public string Undo()
        {
            return Previous;
        }

        public string Previous { get; set; }
    }
}