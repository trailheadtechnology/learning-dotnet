using System;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace session_08
{
    public class DataReaders
    {
        public static void Example()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesLT.Customer", conn))
                {
                    var mem1 = GC.GetTotalMemory(true);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var mem2 = GC.GetTotalMemory(true);

                        var row = 0;
                        while (reader.Read())
                        {
                            var firstName = reader["FirstName"];
                            var lastName = reader["LastName"];
                            Console.WriteLine($"Customer {row} is {firstName} {lastName}");
                            Console.WriteLine();

                            row++;
                        }

                        Console.WriteLine();
                        Console.WriteLine($"DataReader is {(mem2 - mem1):n0} bytes");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
