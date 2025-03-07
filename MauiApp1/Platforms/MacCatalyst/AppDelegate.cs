using Foundation;

namespace MauiApp1.platforms.MacCatalyst;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
   protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp().GetAwaiter().GetResult();

}
