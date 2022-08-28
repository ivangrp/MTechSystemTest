using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Options;
using WebSPA;
using WebSPA.Infraestructure.Config;
using WebSPA.Infraestructure.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddHttpClient<IEmployeeService, EmployeeService>((services, options) =>
{
    var cardHolderApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.Employee;
    options.BaseAddress = new Uri(cardHolderApi);
});

await builder.Build().RunAsync();
