using System.Diagnostics;

namespace MathApp;

internal class UnitTest
{
    public void TestGetSquare()
    {
        MathCalculator calc = new MathCalculator(5);
        double result = calc.GetSquare();

        if (result == 25)
        {
            Debug.WriteLine("[TEST] GetSquare method PASSED.");
        }
        else
        {
            Debug.WriteLine($"[TEST] GetSquare method FAILED. Expected 25, got {result}");
        }
    }

    public void TestGetCube()
    {
        MathCalculator calc = new MathCalculator(5);
        double result = calc.GetCube();

        if (result == 125)
        {
            Debug.WriteLine("[TEST] GetCube method PASSED.");
        }
        else
        {
            Debug.WriteLine($"[TEST] GetCube method FAILED. Expected 125, got {result}");
        }
    }

    // PART 3 TEST
    public void TestGetPowerOfFour()
    {
        // 1. Setup: Create a calculator with the number 5
        MathCalculator calc = new MathCalculator(5);

        // 2. Execute: 5 to the power of 4 (5 * 5 * 5 * 5) should be 625
        double result = calc.GetPowerOfFour();

        // 3. Evaluate
        if (result == 625)
        {
            Debug.WriteLine("[TEST] GetPowerOfFour method PASSED.");
        }
        else
        {
            Debug.WriteLine($"[TEST] GetPowerOfFour method FAILED. Expected 625, got {result}");
        }
    }
}