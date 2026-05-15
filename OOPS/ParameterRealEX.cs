using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; // Importing the namespace for SQL Server database connectivity
namespace OOPS
{
    class DataBaseConnection
    {
        string ConnectionString;
        SqlConnection connection;

        public DataBaseConnection(string connectionString)
        {
            ConnectionString = connectionString;
            connection = new SqlConnection(ConnectionString);
        }
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening database connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
           if(connection.State == ConnectionState.Open)
           {
                connection.Close();
                Console.WriteLine("Database connection closed successfully.");
           } 
        }


    }
    internal class ParameterRealEX
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=UsersDB;Integrated Security=True";
            DataBaseConnection dbConnection = new DataBaseConnection(connectionString);
            dbConnection.OpenConnection();
            // Perform database operations here
            dbConnection.CloseConnection();
        }
    }
}
