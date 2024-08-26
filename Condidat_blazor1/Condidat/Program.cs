using Microsoft.EntityFrameworkCore;
using Condidat.Infrastructure.Context;
using Condidat.Application.Interfaces;
using Condidat.Infrastructure.Repositories;
using Condidat.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextFactory<CondidatDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CondidatConnection"));
});

builder.Services.AddScoped<ICondidatRepository, CondidatRepository>();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCdkx3TXxbf1x0ZFRGalhSTndXUiweQnxTdEFjXn5XcXRRRWFUWEdzXA==");


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



var app = builder.Build();


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