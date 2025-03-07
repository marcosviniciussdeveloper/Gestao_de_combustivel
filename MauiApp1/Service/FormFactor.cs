using MauiApp1.Shared.Services;
using MauiApp1.Shared.Services.Interface;

namespace MauiApp1.Service;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return DeviceInfo.Idiom.ToString();
    }

    public string GetPlatform()
    {
        return DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
    }
}
