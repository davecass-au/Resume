using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Resume;
using Resume.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),    
});

builder.Services.AddScoped<DataService, DataService>();
builder.Services.AddScoped<MenuItems, MenuItems>();
builder.Services.AddScoped<UserOptions, UserOptions>();

await builder.Build().RunAsync();
