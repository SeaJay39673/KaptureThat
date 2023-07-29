using DynamicDisplay_ProofOfConcept.Views;

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
    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);
        if (args.Source == ShellNavigationSource.ShellSectionChanged)
        {
            var navigation = Shell.Current.Navigation;
            var pages = navigation.NavigationStack;
            for (var i  = pages.Count - 1; i >= 1; i--)
            {
                navigation.RemovePage(pages[i]);
            }
        }

        var target = args.Target;
        if (target.Location.OriginalString == "//UploadPhoto")
        {
            KaptureShell.CurrentItem = new UploadPhoto();
        }

    }

}
