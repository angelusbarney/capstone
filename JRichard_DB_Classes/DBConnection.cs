using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Functionality {
    public class DBConnection {
        static string ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\DBSystem.mdf;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        public DBConnection() {
        }
        public SqlConnection GetSqlConnection() {
            if (sqlConnection.State != ConnectionState.Open) {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
        public void CloseSqlConnection() {
            sqlConnection.Close();
        }
        public System.Data.DataSet GetAll(string Text, SqlParameter[] Params) {
            SqlCommand Command = new SqlCommand();
            DataSet Dataset = new DataSet();
            SqlDataAdapter Adapter = null;
            GetSqlConnection();
            PrepareCommand(Command, (SqlTransaction)null, CommandType.StoredProcedure, Text, Params);
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Dataset);
            CloseSqlConnection();
            Command.Parameters.Clear();
            return Dataset;
        }
        public object GetById(SqlConnection Connection, CommandType Commandtype, string Text, SqlParameter[] Params) {
            SqlCommand Command = new SqlCommand();
            object Return = null;
            PrepareCommand(Command, (SqlTransaction)null, Commandtype, Text, Params);
            Return = Command.ExecuteScalar();
            Command.Parameters.Clear();
            return Return;
        }
        public int Add(CommandType Commandtype, string Text, SqlParameter[] Params) {
            SqlCommand Command = new SqlCommand();
            GetSqlConnection();
            PrepareCommand(Command, (SqlTransaction)null, Commandtype, Text, Params);
            int Return = System.Convert.ToInt16(Command.ExecuteScalar());
            Command.Parameters.Clear();
            CloseSqlConnection();
            return Return;
        }
        public int Edit(CommandType Commandtype, string Text, SqlParameter[] Params) {
            SqlCommand Command = new SqlCommand();
            GetSqlConnection();
            PrepareCommand(Command, (SqlTransaction)null, Commandtype, Text, Params);
            string Result = (string)Command.ExecuteScalar();
            int Return = Convert.ToInt32(Result);
            Command.Parameters.Clear();
            CloseSqlConnection();
            return Return;
        }
        public int ExecuteTransaction(SqlTransaction Transaction, CommandType Commandtype, string Text, SqlParameter[] Params) {
            SqlCommand Command = new SqlCommand();
            PrepareCommand(Command, Transaction, Commandtype, Text, Params);
            int Return = Command.ExecuteNonQuery();
            Command.Parameters.Clear();
            return Return;
        }
        public void PrepareCommand(SqlCommand Command, SqlTransaction Transaction, CommandType Commandtype, string Text, SqlParameter[] Params) {
            Command.Connection = sqlConnection;
            Command.CommandText = Text;
            if (Transaction != null) {
                Command.Transaction = Transaction;
            }
            Command.CommandType = Commandtype;
            if (Params != null) {
                AttachParameters(Command, Params);
            }
        }
        public void AttachParameters(SqlCommand Command, SqlParameter[] Params) {
            foreach (SqlParameter P in Params) {
                Command.Parameters.Add(P);
            }
        }
    }
}
