using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAssemblyDemo.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// DI ContainerStorage using Singleton so that it lives till client lifetime
builder.Services.AddSingleton<ContainerStorage>();

await builder.Build().RunAsync();
