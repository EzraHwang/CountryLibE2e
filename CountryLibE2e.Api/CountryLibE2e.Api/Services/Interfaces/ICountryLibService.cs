using CountryLibE2e.Api.Controllers;
using CountryLibE2e.Api.Models;

namespace CountryLibE2e.Api.Services.Interfaces;

public interface ICountryLibService
{
    Task<IEnumerable<Country>> ApiGet();
    IEnumerable<Country> DbGet();
}