using PetControlSystem.Components;
using PetControlSystem.Repositories;
using PetControlSystem.Repositories.Interfaces;
using PetControlSystem.Services;
using PetControlSystem.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository, Repository>();
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
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(PetControlSystem.Client._Imports).Assembly);

app.Run();
