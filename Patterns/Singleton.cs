
using System.Data.SqlClient;

namespace Patterns
{

    /// <summary>
    /// Non - ThreadSafe
    /// </summary>
    /// <returns></returns>
    public class SingletonDatabaseConnection
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=AdventureWorks2022;Integrated Security=True;";
        private static SqlConnection? sqlConnection;

        private static SingletonDatabaseConnection _instance;


        private SingletonDatabaseConnection()
        {
            // private constructor to prevent instantiation from outside the class
            Console.WriteLine("private Const");
        }

        public static SingletonDatabaseConnection getInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("New SQL Conn");
                _instance = new SingletonDatabaseConnection();
                sqlConnection = new SqlConnection(connectionString);
            }
            else
                Console.WriteLine("Old SQL Conn");
            return _instance;
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }

    /// <summary>
    /// ThreadSafe
    /// </summary>
    public class SingletonDatabaseConnection_ThreadSafe
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=AdventureWorks2022;Integrated Security=True;";
        private static SqlConnection? sqlConnection;

        private static SingletonDatabaseConnection_ThreadSafe _instance;

        private static readonly object _lock = new object();


        private SingletonDatabaseConnection_ThreadSafe()
        {
            // private constructor to prevent instantiation from outside the class
            Console.WriteLine("private Const");
        }

        public static SingletonDatabaseConnection_ThreadSafe getInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("New SQL Conn");
                //The lock statement acquires the mutual-exclusion lock for a given object,
                //executes a statement block, and then releases the lock
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonDatabaseConnection_ThreadSafe();
                        sqlConnection = new SqlConnection(connectionString);
                    }
                }
            }
            else
                Console.WriteLine("Old SQL Conn");
            return _instance;
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }

    class TestCalss
    {
        static TestCalss()
        {
            Console.WriteLine("static TestCalss");
        }

        public TestCalss()
        {
            Console.WriteLine("public TestCalss");
        }

        void Method()
        {
            Console.WriteLine("Test Method");
        }
    }
}