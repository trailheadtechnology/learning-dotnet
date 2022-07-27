using System;

namespace session_11
{
    public class CreateExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksEntities())
            {
                var cust = new Customer
                {
                    CompanyName = "Newly Created",
                    FirstName = "First",
                    LastName = "Last",
                    PasswordHash = "awdf",
                    PasswordSalt = "asdf",
                    ModifiedDate = DateTime.Now,
                };
                context.Customers.Add(cust);
                Console.WriteLine($"New Customer ID {cust.CustomerID}");
                Console.ReadKey();

                var effected = context.SaveChanges();
                Console.WriteLine($"{effected} rows created; New Customer ID {cust.CustomerID}");
                Console.ReadKey();
            }
        }
    }
}
