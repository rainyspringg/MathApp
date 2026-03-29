using System;

namespace MathApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // This runs your unit test in the background as soon as the app starts
        UnitTest test = new UnitTest();
        test.TestGetSquare();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (double.TryParse(NumberInput.Text, out double inputNumber))
        {
            MathCalculator calculator = new MathCalculator(inputNumber);

            double square = calculator.GetSquare();

            ResultLabel.Text = $"Square: {square}";
        }
        else
        {
            ResultLabel.Text = "Please enter a valid number.";
        }
    }
}