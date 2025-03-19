using MauiApp1.Shared.Services;
using Microsoft.Extensions.Logging;

using MauiApp1.Shared.Services.Interface;

namespace MauiApp1;

public static class MauiProgram
{
    public static async Task<MauiApp> CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // 🔹 Obtém as credenciais do Supabase
        var url = Environment.GetEnvironmentVariable("SUPABASE_URL")
            ?? throw new InvalidOperationException("SUPABASE_URL não foi encontrada.");

        var key = Environment.GetEnvironmentVariable("SUPABASE_KEY")
            ?? throw new InvalidOperationException("SUPABASE_KEY não foi encontrada.");

        var options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };

        var supabase = new Supabase.Client(url, key, options);
        await supabase.InitializeAsync(); 

       
        builder.Services.AddSingleton<IVeiculoService, VeiculoService>();
        builder.Services.AddSingleton<IAbastecimentoService, AbastecimentoService>();
        builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
        builder.Services.AddSingleton<IManutencaoService, ManutencaoService>();
        builder.Services.AddSingleton<IMotoristaService, MotoristaService>();

        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri("https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/")
        });

        builder.Services.AddMauiBlazorWebView();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
    
            


        
        return builder.Build();
       
    }
}
