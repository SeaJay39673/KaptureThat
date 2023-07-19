namespace DynamicDisplay_ProofOfConcept.Views;

public partial class UploadPhoto : ContentPage
{
	public UploadPhoto()
	{
		InitializeComponent();
	}

    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.NumCamerasDetected > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.InvokeOnMainThreadAsync(async () => {
                var stopResult = await cameraView.StopCameraAsync();
                var startResult = await cameraView.StartCameraAsync();
            });
        }
    }
	async public void Back(object sender, EventArgs e) {
        await cameraView.StopCameraAsync();
		await Shell.Current.GoToAsync(state: "//KaptureBoard");
	}
	public void Kapture(object sender, EventArgs e) {
		
	}
}