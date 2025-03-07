using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiApp1.Shared.Services;
using MauiApp1.Web.Client.Services;
using MauiApp1.Shared.Services.Interface;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MauiApp1.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
