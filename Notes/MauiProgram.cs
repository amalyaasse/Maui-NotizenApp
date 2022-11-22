using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace Notes;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("IndieFlower-Regular.ttf", "IndieFlower-Regular");
				fonts.AddFont("DancingScript-Regular.ttf", "DancingScript-Regular");
				fonts.AddFont("Kalam-Regular.ttf", "Kalam-Regular");
			});

		return builder.Build();
	}
}
