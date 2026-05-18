//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class PrintConnString
//    {
        
//        class DataBaseConnection
//        {
//            // Field to store the connection string
//            private string ConnectionString;

//            // Parameterized Constructor
//            public DataBaseConnection(string connectionString)
//            {
//                // Assigning the parameter value to the class field
//                ConnectionString = connectionString;
//            }

//            // Method to print the connection string
//            public void PrintConnectionString()
//            {
//                Console.WriteLine("--------------------------------------------------");
//                Console.WriteLine("Current Connection String:");
//                Console.WriteLine(ConnectionString);
//                Console.WriteLine("--------------------------------------------------");
//            }
//        }

//        internal class ParameterRealEX
//        {
//            static void Main(string[] args)
//            {
//                // 1. Define the connection string
//                string connStr = "Data Source=.;Initial Catalog=UsersDB;Integrated Security=True";

//                // 2. Pass the connection string as a parameter to the constructor
//                DataBaseConnection dbConnection = new DataBaseConnection(connStr);

//                // 3. Call the method to print it
//                dbConnection.PrintConnectionString();
//            }
//        }
//    }
//}

