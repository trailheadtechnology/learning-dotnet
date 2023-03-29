using Microsoft.Data.SqlClient;
using System;

namespace session_08
{
    public class Commands
    {
        public static void Example()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SalesLT.Customer", conn))
                {
                    var result = (int)cmd.ExecuteScalar();
                    Console.WriteLine($"Customer has {result} records");
                }

                var insertSql = $@"
                        INSERT INTO SalesLT.Customer
                        (
                            NameStyle,
                            Title,
                            FirstName,
                            MiddleName,
                            LastName,
                            Suffix,
                            CompanyName,
                            SalesPerson,
                            EmailAddress,
                            Phone,
                            PasswordHash,
                            PasswordSalt,
                            rowguid,
                            ModifiedDate
                        )
                        VALUES
                        (   DEFAULT,
                            'Mr',
                            'J.',
                            'G',
                            'Tower',
                            NULL,
                            'Trailhead Technology Partners',
                            'adventure-works\pamela0', 
                            'jtower@trailheadtechnology.com',
                            '123-123-1234',   
                            '',      
                            '',      
                            DEFAULT, 
                            DEFAULT  
                        )";
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    var effectedRows = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{effectedRows} rows where inserted");
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SalesLT.Customer", conn))
                {
                    var result = cmd.ExecuteScalar();
                    Console.WriteLine($"Customer has {result} records");
                }

            }


            Console.ReadKey();
        }
    }
}
