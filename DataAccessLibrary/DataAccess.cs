
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
namespace DataAccessLibrary
{
    public class DataAccess
    {

        static string path ="E:\\School\\2015\\PROG 2500 - Andrew\\WIP\\temp\\ManufacturingTest2\\BusinessLogic\\";
        //static string path = "C:\\Users\\Odisey\\Documents\\School\\temp\\ManufacturingTest2\\BusinessLogic\\"; //
        //static string path = "C:\\Users\\w0167370\\Desktop\\DemoProductsDB\\DemoProductsDB\\"; 
        static string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + path + "TestDB.mdf;Integrated Security=True";
        //static string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\w0167370\\Desktop\\March2\\DemoSalesSystem\\SalesSystemDB.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connString);
        //private static SqlConnection connection = new SqlConnection("Data Source=NOVA-9CDA057382;Initial Catalog=DiskManagement;Integrated Security=True");

        //empty default constuctor
        public DataAccess()
        {
            defineConnection("TestDB.mdf");
        }
        public static void defineConnection(string DBName)
        {
            string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + path + DBName + ";Integrated Security=True";
            connection = new SqlConnection(connString);
        }
        #region "GetConnection"

        public static SqlConnection GetConnection()
        {

            //opens the connection, if its not already open returned connection, methods just refer to the connection field
            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            return connection;
        }
        #endregion
        #region "CloseConnection"

        public void CloseConnection()
        {
            //closes the connection
            connection.Close();
        }
        #endregion
        #region "ModifyItems"
        public int ModifyItems(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //CommandType=enum with the following possible values(and apropriate command text to accompany them)
            // text(command text=sql command)
            // stored procedure(command text=procedure name)
            // TableDirect(command text=name of table)
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            int retval = 0;
            //Opens the SqlConnection
            GetConnection();
            //sets the commands properties to the parameters passed with it... not sure how, its not passed by reference
            PrepareCommand(cmd, (SqlTransaction)null, commandType, commandText, commandParameters);
            //finally, execute the command.
            //ExecuteScalar returns an object with "The first column of the first row in the result set, or a null reference if the result set is empty."
            //returned object is converted to a string(can't convert object to int)
            String result = (string)cmd.ExecuteScalar();
            //then converted from string to 32bit integer
            retval = Convert.ToInt32(result);
            //retval = (int)cmd.ExecuteScalar();
            //detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            //closes the connection
            connection.Close();
            //returns integer
            return retval;
        }
        //ExecuteNonQuery
        #endregion
        #region "InsertItems"
        public int modifyDb(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            int retval = 0;
            GetConnection();
            PrepareCommand(cmd, (SqlTransaction)null, commandType, commandText, commandParameters);
            //finally, execute the command.
            //retval = cmd.ExecuteNonQuery();
            retval = System.Convert.ToInt16(cmd.ExecuteScalar());
            //detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            connection.Close();
            return retval;
        }
        //ExecuteNonQuery
        #endregion
        #region "GetDataWithReader"
        public static SqlDataReader getDataWithReader(string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand(commandText, GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        #endregion
        #region "Get Single Data Item"
        public static object GetSingleDataItem(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            //create a null object for the data to be returned to
            object retval = null;
            PrepareCommand(cmd, (SqlTransaction)null, commandType, commandText, commandParameters);
            //execute the command & return the results
            retval = cmd.ExecuteScalar();
            //detach the SqlParameters from the command object, so they can be used again... same as above.
            cmd.Parameters.Clear();
            return retval;
        }
        //ExecuteScalar
        #endregion
        #region "GetDataSet"
        public static System.Data.DataSet GetDataSet(string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            //The DataSet consists of a collection of DataTable objects that you can relate to each other with DataRelation objects.
            //DataTable object represents one table of in-memory data.
            System.Data.DataSet ds = new System.Data.DataSet();
            //SqlDataAdapter = class to fill a data set object with information from a database connection
            SqlDataAdapter da = null;
            //Opens the connection object
            GetConnection();
            ////sets the commands properties to the parameters passed with it
            PrepareCommand(cmd, (SqlTransaction)null, CommandType.StoredProcedure, commandText, commandParameters);
            //create the DataAdapter, passes it the prepared SqlCommand object to use to retrieve the data to fill the data set
            da = new SqlDataAdapter(cmd);
            //fill the DataSet using default values for DataTable names, etc.
            da.Fill(ds);
            //close the connection
            connection.Close();
            //detach the SqlParameters from the command object, so they can be used again (same as above)
            cmd.Parameters.Clear();
            //return the dataset
            return ds;
        }
        //ExecuteDataset
        #endregion
        #region "Execute Transaction"
        public static int ExecuteTransaction(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            int retval = 0;

            //sets the commands properties to the parameters passed with it
            PrepareCommand(cmd, transaction, commandType, commandText, commandParameters);

            //finally, execute the command.
            //ExecuteNonQuery runs sends an SqlCommand to the database and only returns the number of rows affected
            retval = cmd.ExecuteNonQuery();

            //detach the SqlParameters from the command object, so they can be used again (same as above)
            cmd.Parameters.Clear();

            //returns the number of affected rows
            return retval;

        }
        //ExecuteNonQuery
        #endregion
        #region "helper functions"
        private static void PrepareCommand(SqlCommand command, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            //associate the connection with the command
            command.Connection = connection;
            //set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;
            //if we were provided a transaction, assign it.
            if ((transaction != null))
            {
                command.Transaction = transaction;
            }
            //set the command type
            command.CommandType = commandType;
            //attach the command parameters if they are provided
            if ((commandParameters != null))
            {
                //loops through the command parameters array and adds each one to the Commands Parameters ID
                AttachParameters(command, commandParameters);
            }
            return;
        }
        //PrepareCommand
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            //loops through the command parameters array and adds each one to the Command's Parameters ID
            SqlParameter p = null;
            foreach (SqlParameter p_loopVariable in commandParameters)
            {
                p = p_loopVariable;
                command.Parameters.Add(p);
            }
        }
        //AttachParameters
        #endregion
    }

}
