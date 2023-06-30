
using System.Data.SqlClient;

namespace Patterns
{
    public class SingletonDatabaseConnection
    {
        private  string connectionString = @"YOUR-CONNECTION-STRING";
        private static SqlConnection? sqlConnection;

        private static SingletonDatabaseConnection instance;

        private SingletonDatabaseConnection()
        {
            // private constructor to prevent instantiation from outside the class
        }

        public static SingletonDatabaseConnection getInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("New SQL Conn");
                instance = new SingletonDatabaseConnection();
                //sqlConnection = new SqlConnection(connectionString);
            }
            else
                Console.WriteLine("Old SQL Conn");
            return instance;
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}