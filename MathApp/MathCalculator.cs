using System;

namespace MathApp;

public class MathCalculator
{
    public double Number { get; set; }

    public MathCalculator(double number)
    {
        Number = number;
    }

    public double GetSquare()
    {
        return Number * Number;
    }

    // PART 2 FEATURE: Get the Cube
    public double GetCube()
    {
        return Math.Pow(Number, 3);
    }
}