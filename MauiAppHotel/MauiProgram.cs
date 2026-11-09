using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("DMSans-Regular.ttf", "DMSansRegular");
                    fonts.AddFont("DMSans-Italic.ttf", "DMSansItalic");
                    fonts.AddFont("Redaction10-Bold.ttf", "Redaction10Bold");
                    fonts.AddFont("Redaction10-Italic.ttf", "Redaction10Italic");
                    fonts.AddFont("Redaction10-Regular.ttf", "Redaction10Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
