﻿namespace DynamicDisplay_ProofOfConcept;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
    protected void OnNavigating(ShellNavigatingEventArgs args)
    {
		var target = args.Target;
    }
}
