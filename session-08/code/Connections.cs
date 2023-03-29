using Microsoft.Data.SqlClient;
using System;
using System.Data.Odbc;
using System.Data.OleDb;

namespace session_08
{
    public class Connections
    {
        public static void Example()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;"))
            {
                conn.Open();
                Console.WriteLine($"SqlConnection is {conn.State}");
            }

            using (OleDbConnection conn = new OleDbConnection(@"Data Source=np:\\.\pipe\LOCALDB#4114C8D8\tsql\query;Initial Catalog=AdventureWorks;Integrated Security=SSPI;Provider=sqloledb;"))
            {
                conn.Open();
                Console.WriteLine($"OleDbConnection is {conn.State}");
            }

            using (OdbcConnection conn = new OdbcConnection(@"Server=np:\\.\pipe\LOCALDB#4114C8D8\tsql\query;Database=AdventureWorks;Trusted_Connection=Yes;Driver={SQL Server};"))
            {
                conn.Open();
                Console.WriteLine($"OdbcConnection is {conn.State}");
            }

            Console.ReadKey();
        }
    }
}
