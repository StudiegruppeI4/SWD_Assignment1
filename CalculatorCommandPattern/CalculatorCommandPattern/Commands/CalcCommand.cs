namespace CalculatorCommandPattern
{
    public interface CalcCommand
    {
        void Execute(ref string expression);
        string Undo();
        string Previous { get; set; }
    }
}