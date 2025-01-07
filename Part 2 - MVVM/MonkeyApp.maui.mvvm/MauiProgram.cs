using Microsoft.Extensions.Logging;
using MonkeyApp.maui.mvvm.ViewModels;

namespace MonkeyApp.maui.mvvm
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

            return builder.Build();
        }
    }
}
