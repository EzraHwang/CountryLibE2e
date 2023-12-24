using System.Data;
using CountryLibE2e.Api.Models;

namespace CountryLibE2e.Api.Repositories.Interfaces
{
    public interface ICountryLibRepository
    {
        IEnumerable<Country> GetCountryInfo();
    }
}
