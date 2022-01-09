using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Ordering.Infrastructure.Data
{
    public class DBConnector
    {
          private readonly IConfiguration configuration;
        protected DBConnector(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection() {
            string _connectionString = configuration.GetConnectionString("OrderingConnection");
            return new SqlConnection(_connectionString);
        }
    }
}