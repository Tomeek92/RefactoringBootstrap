using BlazorCleanArchitecture.UI.Components;
using BlazorCleanArchitecture.UI.ServiceAPI;
using CleanArchitectureBlazor.Application.Service;
using CleanArchitectureBlazor.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddHttpClient<NewsLetterEmailServiceAPI>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7191");
});
builder.Services.AddScoped<NewsLetterEmailServiceAPI>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

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

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
