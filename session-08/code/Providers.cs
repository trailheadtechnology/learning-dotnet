using System;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace session_08
{
    public class Providers
    {
        public static void Example()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;";
                connection.Open();
                Console.WriteLine($"DbConnection is {connection.State}");
            }

            Console.ReadKey();
        }
    }
}
