using System.Reflection.Metadata.Ecma335;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class Account : ContentPage
{
	public Account()
	{
		InitializeComponent();
	}
	
	async public void AccountSettings(object sender, System.EventArgs e)
	{
		await Shell.Current.GoToAsync(state: "//AccountSettings");
	}
}