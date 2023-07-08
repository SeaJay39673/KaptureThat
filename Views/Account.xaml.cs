using DynamicDisplay_ProofOfConcept.Views.AccountSettings;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class Account : ContentPage
{
    public Account()
    {
        InitializeComponent();
    }

    async public void AccountSettings(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new AccountSettingsPage());
    }
}