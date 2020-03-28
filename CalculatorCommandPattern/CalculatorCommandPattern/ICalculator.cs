namespace CalculatorCommandPattern
{
    public interface ICalculator
    {
        void CalcButtonPushed(int button);
        void ValueButtonPushed(int button);
        void UndoButtonPushed();
    }
}