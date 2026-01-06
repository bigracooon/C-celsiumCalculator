using System;
using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Calculate(object? sender, RoutedEventArgs e)
    {
        try
        {
            if (Celsius.Text != null)
            {
                var c = double.Parse(Celsius.Text);
                var f = c * (9d / 5d) + 32;
                Fahrenheit.Text = f.ToString(f.ToString(CultureInfo.InvariantCulture));
            }

            ErrorMessage.IsVisible = false;
        }
        catch (Exception exception)
        {
            ErrorMessageTextBlock.Text = exception.Message;
            ErrorMessage.IsVisible = true;
        }
    }
}
