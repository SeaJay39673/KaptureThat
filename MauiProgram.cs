﻿using AppActions.Icons.Maui;
using Camera.MAUI;

namespace DynamicDisplay_ProofOfConcept;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCameraView()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
			})
			.ConfigureEssentials(essentials =>
			{
				essentials
					.UseAppActionIcons();
			});

		return builder.Build();
	}
}
