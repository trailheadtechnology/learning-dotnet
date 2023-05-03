using session_11.Data;
using System;
using System.Linq;

namespace session_11
{
    public class DeleteExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksContext())
            {
                var query = from customer in context.Customers
                            where customer.FirstName == "First" && customer.LastName == "Last"
                            select customer;

                var customersToDelete = query.ToList();
                
                context.Customers.RemoveRange(customersToDelete);
                var effected = context.SaveChanges();
                Console.WriteLine($"{effected} rows deleted");
                Console.ReadKey();
            }
        }
    }
}
