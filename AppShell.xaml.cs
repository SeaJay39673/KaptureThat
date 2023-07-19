namespace DynamicDisplay_ProofOfConcept;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        var LoggedIn = Preferences.Get("LoggedIn", false);

        if (LoggedIn)
        {
            KaptureShell.CurrentItem = KaptureBoard;
        }
        else
        {
            KaptureShell.CurrentItem = Login;
        }
    }
    protected override async void OnNavigating(ShellNavigatingEventArgs args)
    {
        var target = args.Target;
    }
}
