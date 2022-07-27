using System;
using System.Linq;

namespace session_11
{
    public class ReadExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksEntities())
            {
                // CHANGE TRACKING
                //context.Configuration.AutoDetectChangesEnabled = false;

                // method syntax
                var cust = context.Customers
                            .FirstOrDefault(c => c.CustomerID == 1);
                    //.Where(c => c.CustomerID == 1)
                    //.FirstOrDefault();

                Console.WriteLine($"{cust.CustomerID} {cust.FirstName} {cust.LastName}");
                Console.ReadKey();

                // query syntax
                var query = from customer in context.Customers
                            select customer; // new { customer.CustomerID, customer.FirstName, customer.LastName };

                //var results = query.ToList();
                ////...thousands of lines of code...
                //var c2 = query.FirstOrDefault(c => c.CustomerID == 1);
                //var c1 = results.FirstOrDefault(c => c.CustomerID == 1);

                foreach (var cust2 in query) // IQueryable vs IEnumerable
                {
                    Console.WriteLine($"{cust2.CustomerID} {cust2.FirstName} {cust2.LastName}");
                }
                Console.ReadKey();
            }
        }
    }
}
