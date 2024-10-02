using FutureWave.Web;
using FutureWave.Web.Services;
using FutureWave.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7139/") });

builder.Services.AddScoped<IProductService, ProductService > ();
builder.Services.AddScoped<IUserService, UserService>();
await builder.Build().RunAsync();
