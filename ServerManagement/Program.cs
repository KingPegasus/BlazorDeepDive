using Microsoft.EntityFrameworkCore;
using ServerManagement.Components;
using ServerManagement.Data;
using ServerManagement.Models;
using ServerManagement.StateStore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// AddDbContext is scoped. AddDbContextFactory is Singleton
builder.Services.AddDbContextFactory<ServerManagementContext>( options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorManagement"));
});

// Add services to the container.
builder.Services.AddRazorComponents().
    AddInteractiveServerComponents();

//builder.Services.AddTransient<SessionStorage>();
builder.Services.AddScoped<ContainerStorage>(); // use scoped for web server for privacy using signalR channel.
builder.Services.AddScoped<TorontoOnlineServersStore>();

builder.Services.AddTransient<IServersEFCoreRepository, ServersEFCoreRepository>();

builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().
    AddInteractiveServerRenderMode();

app.Run();
