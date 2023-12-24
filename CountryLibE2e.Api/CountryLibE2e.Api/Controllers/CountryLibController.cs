using CountryLibE2e.Api.Models;
using CountryLibE2e.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable CS8603 // Possible null reference return.

namespace CountryLibE2e.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CountryLibController : ControllerBase
{
    private readonly ICountryLibService _countryLibService;

    public CountryLibController(ICountryLibService countryLibService)
    {
        _countryLibService = countryLibService;
    }

    [HttpGet(Name = "ApiGet")]
    public async Task<IEnumerable<Country>> ApiGet()
    {
        return await _countryLibService.ApiGet();
    }
    
    [HttpGet(Name = "DbGet")]
    public Task<IEnumerable<Country>> DbGet()
    {
        return Task.FromResult(_countryLibService.DbGet());
    }
}