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
}