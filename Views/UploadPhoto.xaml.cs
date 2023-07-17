using ZXing;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class UploadPhoto : ContentPage
{
	public UploadPhoto()
	{
		InitializeComponent();
	}
	public void Cameras_Loaded(object sender, EventArgs e)
	{
		if (cameraView.NumCamerasDetected > 0)
		{
			cameraView.Camera = cameraView.Cameras.First();
			MainThread.InvokeOnMainThreadAsync(async () => {
				await cameraView.StopCameraAsync();
				var result = await cameraView.StartCameraAsync();
			});
		}
	}
}