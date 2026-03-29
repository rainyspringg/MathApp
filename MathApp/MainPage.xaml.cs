using System;

namespace MathApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Run our unit tests silently in the background
        UnitTest test = new UnitTest();
        test.TestGetSquare();
        test.TestGetCube();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (double.TryParse(NumberInput.Text, out double inputNumber))
        {
            MathCalculator calculator = new MathCalculator(inputNumber);

            double square = calculator.GetSquare();
            double cube = calculator.GetCube(); // Calculate the cube

            // Display both results
            ResultLabel.Text = $"Square: {square}\nCube: {cube}";
        }
        else
        {
            ResultLabel.Text = "Please enter a valid number.";
        }
    }
}