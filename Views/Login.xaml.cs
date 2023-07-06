using DynamicDisplay_ProofOfConcept.ViewModels;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}