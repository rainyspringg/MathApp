using System;

namespace MathApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        UnitTest test = new UnitTest();
        test.TestGetSquare();
        test.TestGetCube();
        test.TestGetPowerOfFour(); // Run the new test
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (double.TryParse(NumberInput.Text, out double inputNumber))
        {
            MathCalculator calculator = new MathCalculator(inputNumber);

            double square = calculator.GetSquare();
            double cube = calculator.GetCube();
            double powerOfFour = calculator.GetPowerOfFour(); // Calculate the power of 4

            // Display all results
            ResultLabel.Text = $"Square: {square}\nCube: {cube}\nPower of 4: {powerOfFour}";
        }
        else
        {
            ResultLabel.Text = "Please enter a valid number.";
        }
    }
}