using DynamicDisplay_ProofOfConcept.ViewModels;
using System.Windows.Input;

namespace DynamicDisplay_ProofOfConcept.Views.AccountSettings;

public partial class AccountSettingsPage : ContentPage
{
	public AccountSettingsPage()
	{
		InitializeComponent();
	}
	async public void Logout(object sender, EventArgs e)
	{
        Preferences.Set("LoggedIn", false);
        await Shell.Current.GoToAsync(state: "//Login");
		await Navigation.PopAsync();
    }
	async public void ManageAccount(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ManageAccount());
	}

}