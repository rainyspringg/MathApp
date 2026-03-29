using System;

namespace MathApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        // For the initial prototype, we just output this text regardless of the input.
        ResultLabel.Text = "This is a prototype.";
    }
}