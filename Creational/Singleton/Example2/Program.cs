using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection dbConnection = DatabaseConnection.GetInstance();
            IDbConnection connection = dbConnection.GetConnection();

            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Database connection closed");
            }
        }
    }
}
