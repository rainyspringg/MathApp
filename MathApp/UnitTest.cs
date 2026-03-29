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

    // PART 2 TEST
    public void TestGetCube()
    {
        // 1. Setup: Create a calculator with the number 5
        MathCalculator calc = new MathCalculator(5);

        // 2. Execute: 5 cubed (5 * 5 * 5) should be 125
        double result = calc.GetCube();

        // 3. Evaluate
        if (result == 125)
        {
            Debug.WriteLine("[TEST] GetCube method PASSED.");
        }
        else
        {
            Debug.WriteLine($"[TEST] GetCube method FAILED. Expected 125, got {result}");
        }
    }
}