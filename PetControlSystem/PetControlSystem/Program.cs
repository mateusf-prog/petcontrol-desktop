using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetControlSystem.Components;
using PetControlSystem.Models;
using PetControlSystem.Repositories;
using PetControlSystem.Services;
using PetControlSystem.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1);
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version"));
});

// Registrar outros serviços
builder.Services.AddScoped<Repository>();

builder.Services.AddScoped<IAgenda, AgendaService>();
builder.Services.AddScoped<IPetSupport, PetSupportService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IPet, PetService>();
builder.Services.AddScoped<IProduct, ProductService>();
builder.Services.AddScoped<IOrder, OrderService>();
builder.Services.AddScoped<ICustomer, CustomerService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(PetControlSystem.Client._Imports).Assembly);

app.Run();
