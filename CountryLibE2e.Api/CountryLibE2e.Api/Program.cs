using CountryLibE2e.Api.Controllers;
using CountryLibE2e.Api.Repositories;
using CountryLibE2e.Api.Repositories.Interfaces;
using CountryLibE2e.Api.Services;
using CountryLibE2e.Api.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient<ICountryLibService, CountryLibService>().SetHandlerLifetime(TimeSpan.FromSeconds(5));
builder.Services.AddScoped<ICountryLibService, CountryLibService>();
builder.Services.TryAddSingleton<ICountryLibRepository, CountryLibRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();