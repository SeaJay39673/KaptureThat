using DynamicDisplay_ProofOfConcept.ViewModels;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class KaptureBoard : ContentPage
{
	public KaptureBoard()
	{
        InitializeComponent();
		BindingContext = new KaptureBoardViewModel();
	}

}