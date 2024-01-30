namespace UserAppThemeTest;

public partial class MainPage : ContentPage
{
    private int _count;
    private bool _isDarkMode;
    
    public MainPage()
    {
        InitializeComponent();
        
        _isDarkMode = Application.Current!.RequestedTheme switch
        {
            AppTheme.Dark => true,
            AppTheme.Light => false,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        if (_count == 1)
            CounterBtn.Text = $"Clicked {_count} time";
        else
            CounterBtn.Text = $"Clicked {_count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void NavigateToSettings(object? sender, EventArgs e)
    {
        Shell.Current.GoToAsync("/SettingsPage");
    }

    private void ThemeChange_OnClicked(object? sender, EventArgs e)
    {
        _isDarkMode = !_isDarkMode;
        Application.Current!.UserAppTheme = _isDarkMode ? AppTheme.Dark : AppTheme.Light;
    }
}