using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CountryLibE2e.Api.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration _configuration;

        protected BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IEnumerable<T> Query<T>(string spName, object parameters = null, string database = "CountryLib.Db")
        {
            var cnnString = _configuration.GetConnectionString(database);
            using var conn = new SqlConnection(cnnString);
            var sql = conn.Query<T>(spName, parameters, null, true, 180, CommandType.StoredProcedure);
            return sql;
        }
    }
}