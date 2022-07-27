using System;
using System.Linq;

namespace session_11
{
    public class DeleteExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksEntities())
            {
                var query = from customer in context.Customers
                            where customer.FirstName == "First" && customer.LastName == "Last"
                            select customer;

                context.Customers.RemoveRange(query.ToList());
                var effected = context.SaveChanges();
                Console.WriteLine($"{effected} rows deleted");
                Console.ReadKey();
            }
        }
    }
}
