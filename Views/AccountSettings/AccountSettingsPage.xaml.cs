using DynamicDisplay_ProofOfConcept.ViewModels;
using System.Windows.Input;

namespace DynamicDisplay_ProofOfConcept.Views.AccountSettings;

public partial class AccountSettingsPage : ContentPage
{
	public AccountSettingsPage()
	{
		InitializeComponent();
		BindingContext = new AccountSettingsViewModel();
	}
	public void ReturnToSourcePage(object sender, EventArgs args)
	{
		Navigation.PopAsync();
	}
}