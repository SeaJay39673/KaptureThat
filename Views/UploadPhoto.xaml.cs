using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Presentation;

namespace DynamicDisplay_ProofOfConcept.Views;

public partial class UploadPhoto : ContentPage
{
    public double ScreenWidth { get; set; }
    public double ScreenHeight { get; set; }
    public int ButtonValue { get; set; }
    public int ButtonFont { get; set; }
    public Microsoft.Maui.Thickness MarginPlacement { get; set; }
	public UploadPhoto()
	{
        ScreenWidth = getWidth();
        ScreenHeight = getHeight();
        ButtonValue  = (int)(ScreenHeight / 9);
        ButtonFont = (int)(ButtonValue / 2);
        MarginPlacement = new Microsoft.Maui.Thickness(0, -(ButtonValue + 100), 0, 0);
		InitializeComponent();
        this.BindingContext = this;
    }

    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.NumCamerasDetected > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.InvokeOnMainThreadAsync(async () =>
            {
                var stopResult = await cameraView.StopCameraAsync();
                var startResult = await cameraView.StartCameraAsync();
            });
        }
    }
	async public void Back(object sender, EventArgs e) {
		await Shell.Current.GoToAsync(state: "//KaptureBoard");
	}
	public void Kapture(object sender, EventArgs e) {
		
	}
    public double getWidth()
    {
        return DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
    }
    public double getHeight()
    {
        return DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density;
    }
}