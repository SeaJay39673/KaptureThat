using DynamicDisplay_ProofOfConcept.ViewModels;
using DynamicDisplay_ProofOfConcept.Views.AccountSettings;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class Account : ContentPage
{
    public Account() {
        InitializeComponent();
        BindingContext = new AccountViewModel();
        
    }

    async public void AccountSettings(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new AccountSettingsPage());
    }
    async public void Kaptures(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new KaptureTree());
    }

  
}