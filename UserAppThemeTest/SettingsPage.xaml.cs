namespace UserAppThemeTest;

public partial class SettingsPage : ContentPage
{
    private bool _isDarkMode;

    public SettingsPage()
    {
        InitializeComponent();
        
        _isDarkMode = Application.Current!.RequestedTheme switch
        {
            AppTheme.Dark => true,
            AppTheme.Light => false,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    private void ThemeChange_OnClick(object? sender, EventArgs e)
    {
        _isDarkMode = !_isDarkMode;

        Application.Current!.UserAppTheme = _isDarkMode ? AppTheme.Dark : AppTheme.Light;
    }
}