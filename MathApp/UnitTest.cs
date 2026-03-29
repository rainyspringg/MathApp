using System.Diagnostics;

namespace MathApp;

internal class UnitTest
{
    public void TestGetSquare()
    {
        // 1. Setup: Create a calculator and give it the number 5
        MathCalculator calc = new MathCalculator(5);

        // 2. Execute: 5 squared should be 25
        double result = calc.GetSquare();

        // 3. Evaluate
        if (result == 25)
        {
            Debug.WriteLine("[TEST] GetSquare method PASSED.");
        }
        else
        {
            Debug.WriteLine($"[TEST] GetSquare method FAILED. Expected 25, got {result}");
        }
    }
}