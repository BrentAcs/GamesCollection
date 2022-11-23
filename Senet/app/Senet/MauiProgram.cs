using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Senet.ViewModels;

namespace Senet;

public static class MauiProgram
{
   public static MauiApp CreateMauiApp()
   {
      var builder = MauiApp.CreateBuilder();
      builder
         .UseMauiApp<App>()
         // .UseMauiCommunityToolkit()
         .ConfigureFonts(fonts =>
         {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
         })
         .RegisterAppServices()
         .RegisterViewModels()
         .RegisterViews();

#if DEBUG
      builder.Logging.AddDebug();
#endif

      return builder.Build();
   }
   
   public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
   {
      // builder.Services.AddSingleton<IPlanetarySystemService, PlanetarySystemService>();

      return builder;
   }

   public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
   {
      builder.Services.AddSingleton<GameBoardViewModel>();
      builder.Services.AddSingleton<ClockViewModel>();
      
      return builder;
   }

   public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
   {
      builder.Services.AddTransient<MainPage>();

      return builder;
   }
   
}
