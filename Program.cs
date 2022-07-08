using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using IgApplication;
using IgApplication.Northwind;
using IgApplication.NorthwindCloudApp1;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<NorthwindCloudApp1Service>();

RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbDataGridModule),
        typeof(IgbDataGridToolbarModule)
    );
}