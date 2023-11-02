using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Example2
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private static readonly object lockObject = new object();
        private IDbConnection connection;

        private DatabaseConnection() 
        {
            string connectionString = "";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if(instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                }
            }
            return instance;   
        }

        public IDbConnection GetConnection()
        {
            return connection;
        }
    }
}
