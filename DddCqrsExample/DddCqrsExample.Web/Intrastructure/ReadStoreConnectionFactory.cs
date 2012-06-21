using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DddCqrsExample.Web.Intrastructure
{
    public class ReadStoreConnectionFactory : IReadStoreConnectionFactory
    {
        public IDbConnection Create()
        {
            var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReadStore"].ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}