using MauiApp1.Shared.Services;
using MauiApp1.Shared.Services.Interface;

namespace MauiApp1.Web.Client.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "WebAssembly";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
