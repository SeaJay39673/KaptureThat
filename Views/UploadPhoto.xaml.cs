using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Presentation;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class UploadPhoto : ContentPage
{
    public double ScreenWidth { get; set; }
    public double ScreenHeight { get; set; }
	public UploadPhoto()
	{
        ScreenWidth = getWidth();
        ScreenHeight = getHeight();
		InitializeComponent();
    }

    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.NumCamerasDetected > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            cameraView.AutoStartPreview = true;
            //MainThread.InvokeOnMainThreadAsync(async () => {
            //    var stopResult = await cameraView.StopCameraAsync();
            //    var startResult = await cameraView.StartCameraAsync();
            //});
        }
    }
	async public void Back(object sender, EventArgs e) {
		await Shell.Current.GoToAsync(state: "//KaptureBoard");
	}
	public void Kapture(object sender, EventArgs e) {
		
	}
    public double getWidth()
    {
        return DeviceDisplay.Current.MainDisplayInfo.Width / 2;
    }
    public double getHeight()
    {
        return DeviceDisplay.Current.MainDisplayInfo.Height / 2;
    }
}