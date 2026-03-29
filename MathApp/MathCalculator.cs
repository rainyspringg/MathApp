namespace MathApp;

public class MathCalculator
{
    public double Number { get; set; }

    public MathCalculator(double number)
    {
        Number = number;
    }

    // The function we will be testing
    public double GetSquare()
    {
        return Number * Number;
    }
}