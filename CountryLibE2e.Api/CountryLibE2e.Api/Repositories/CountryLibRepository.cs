using CountryLibE2e.Api.Models;
using CountryLibE2e.Api.Repositories.Interfaces;

namespace CountryLibE2e.Api.Repositories
{
    public class CountryLibRepository : BaseRepository, ICountryLibRepository
    {
        private readonly string _dbName;

        public CountryLibRepository(IConfiguration configuration) : base(configuration)
        {
            _dbName = "CountryLib.Db";
        }

        public IEnumerable<Country> GetCountryInfo()
        {
            return Query<Country>("GetCountryInfo_1.0.0", _dbName).ToList();
        }
    }
}