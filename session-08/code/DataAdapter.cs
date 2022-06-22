using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace session_08
{
    public class DataAdapter
    {
        public static void Example()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;"))
            {
                conn.Open();

                var mem1 = GC.GetTotalMemory(true);
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SalesLT.Customer", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);

                    var mem2 = GC.GetTotalMemory(true);

                    for (int i = 0; i < (dt.Rows.Count > 10 ? 10 : dt.Rows.Count); i++)
                    {
                        var firstName = dt.Rows[i]["FirstName"];
                        var lastName = dt.Rows[i]["LastName"];
                        Console.WriteLine($"Customer {i} is {firstName} {lastName}");
                    }

                    Console.WriteLine();
                    Console.WriteLine($"DataTable is {(mem2 - mem1):n0} bytes");
                }
            }

            Console.ReadKey();
        }
    }
}
