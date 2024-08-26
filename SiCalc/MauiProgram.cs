using Microsoft.Extensions.Logging;

namespace SiCalc
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("Cairo-ExtraLight.ttf", "Cairo-ExtraLight");
					fonts.AddFont("Cairo-Light.ttf", "Cairo-Light");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
