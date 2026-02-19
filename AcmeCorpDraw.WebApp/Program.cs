using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.WebApp.Components;
using AcmeCorpDraw.WebApp.Data;
using AcmeCorpDraw.WebApp.Repositories;
using AcmeCorpDraw.WebApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Services for API controllers 
builder.Services.AddHttpClient();
builder.Services.AddControllers();

// Look for the connection string in the configuration and throw an exception if it's not found.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

// Register the DbContext with the connection string.
builder.Services.AddDbContext<AcmeDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ISubmissionRepository, SubmissionRepository>();
builder.Services.AddScoped<ISerialNumberRepository, SerialNumberRepository>();
builder.Services.AddScoped<ISubmissionService, SubmissionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapControllers();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
