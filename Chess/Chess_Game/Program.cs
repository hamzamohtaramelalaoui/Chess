using Chess_Game.Components;
using Microsoft.EntityFrameworkCore;
using Chess_Game.Infrastructure.Context;
using Chess_Game.Infrastructure.Repositories;
using Chess_Game.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Chess_Game.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllersWithViews();


builder.Services.AddDbContextFactory<Chess_GameDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("myConnection"));
});

builder.Services.AddScoped<IChess_GameRepository, Chess_GameRepository>();

builder.Services.AddSingleton<SharedDataService>();

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
