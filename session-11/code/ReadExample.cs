using session_11.Data;
using System;
using System.Data.Entity;
using System.Linq;

namespace session_11
{
    public class ReadExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksContext())
            {
                // CHANGE TRACKING
                //context.Configuration.AutoDetectChangesEnabled = false;

                // method syntax
                var cust = context.Customers
                    .Where(c => c.CustomerId == 1).FirstOrDefault();
                    //.Find(1);
                    //.FirstOrDefault(c => c.CustomerId == 1);

                Console.WriteLine($"{cust.CustomerId} {cust.FirstName} {cust.LastName}");
                Console.ReadKey();

                // query syntax
                var query = from customer in context.Customers
                            select customer; // new { customer.CustomerId, customer.FirstName, customer.LastName };

                //var results = query.ToList();
                //////...thousands of lines of code...
                //var c2 = query.Where(c => c.CustomerId == 1);
                //var c1 = results.FirstOrDefault(c => c.CustomerId == 1);

                foreach (var cust2 in query) // IQueryable vs IEnumerable
                {
                    Console.WriteLine($"{cust2.CustomerId} {cust2.FirstName} {cust2.LastName}");
                }
                Console.ReadKey();
            }
        }
    }
}
