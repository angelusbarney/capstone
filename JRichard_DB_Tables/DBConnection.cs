using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace JRichard_DB_Tables {
    public class DBConnection {
        static string ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\DBSystem.mdf;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        public DBConnection() {
        }
        public SqlConnection GetSqlConnection(string DBName) {
            if (sqlConnection.State != ConnectionState.Open) {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
    }
}
