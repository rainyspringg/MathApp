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

    public double GetCube()
    {
        return Math.Pow(Number, 3);
    }

    // PART 3 FEATURE: Get the Power of 4
    public double GetPowerOfFour()
    {
        return Math.Pow(Number, 4);
    }
}