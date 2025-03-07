using MauiApp1.Shared.Services;
using MauiApp1.Shared.Services.Interface;

namespace MauiApp1.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
