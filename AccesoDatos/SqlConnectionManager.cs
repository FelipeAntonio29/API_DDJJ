using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccesoDatos
{
    public abstract class SqlConnectionManager
    {
        private static SqlConnection SqlConnectionBD35()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["BaseBD35"].ConnectionString);
        }

        public static IDbConnection CreateConnectionBD35()
        {
            var conn = SqlConnectionBD35();
            conn.Open();
            return conn;
        }
    }
}
