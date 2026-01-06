using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;

namespace AvaloniaApplication1.Controls.Buttons;

public partial class DefaultButton : UserControl
{
    public static readonly StyledProperty<string?> TextProperty =
        AvaloniaProperty.Register<DefaultButton, string?>(nameof(Text));

    public static readonly StyledProperty<ICommand?> CommandProperty =
        AvaloniaProperty.Register<DefaultButton, ICommand?>(nameof(Command));

    public string? Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public ICommand? Command
    {
        get => GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public DefaultButton()
    {
        InitializeComponent();
    }
}
