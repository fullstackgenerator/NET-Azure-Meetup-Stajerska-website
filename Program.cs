using MeetupWebsite.Sessionize;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Json;

namespace MeetupWebsite;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        // Load configuration from wwwroot/appsettings.json
        var http = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
        
        using var response = await http.GetAsync("appsettings.json");
        using var stream = await response.Content.ReadAsStreamAsync();
        builder.Configuration.AddJsonStream(stream);

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddScoped<SessionizeClient>();

        await builder.Build().RunAsync();
    }
}