using BarcodeScanner.Mobile;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;


namespace GeometriaMauiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitCore()
            .UseMauiCommunityToolkitCamera()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers(handlers => {
                handlers.AddBarcodeScannerHandler();
            }); ;

#if DEBUG
		builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Trace); // Nivel de detalle máximo
#endif

        return builder.Build();
    }
}
