﻿namespace UserAppThemeTest;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
    }
}