using Foundation;

namespace MauiApp1.Platforms.Ios;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp().GetAwaiter().GetResult();

}
