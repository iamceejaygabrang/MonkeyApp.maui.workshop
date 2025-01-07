using Microsoft.Extensions.Logging;
using MonkeyApp.maui.nav.Services;
using MonkeyApp.maui.nav.ViewModels;
using MonkeyApp.maui.nav.Views;

namespace MonkeyApp.maui.nav
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MonkeysViewModel>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MonkeyService>();
            builder.Services.AddTransient<DetailsViewModel>();
            builder.Services.AddTransient<DetailsPage>();

            return builder.Build();
        }
    }
}
