using Masa.Blazor;
using Masa.Blazor.Presets;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SoBugger.PwaClient;
using SoBugger.PwaClient.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMasaBlazor(options =>
{
    options.Defaults = new Dictionary<string, IDictionary<string, object?>?>()
    {
        {
            PopupComponents.SNACKBAR, new Dictionary<string, object?>()
            {
                { nameof(PEnqueuedSnackbars.Closeable), true },
                { nameof(PEnqueuedSnackbars.Position), SnackPosition.TopCenter }
            }
        }
    };
});

builder.Services.AddScoped<IToastService, ToastService>();

await builder.Build().RunAsync();
