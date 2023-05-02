using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace session_11
{
    public class NavigationProperties
    {
        public static void Example()
        {
            using (var context = new AdventureWorksEntities())
            {
                context.Database.Log = s => Debug.WriteLine(s);
                context.Configuration.LazyLoadingEnabled = false;

                //// BEWARE of LazyLoading
                //var query = from customer in context.Customers
                //            where customer.CustomerAddresses.Any(ca => ca.Address.StateProvince == "Washington")
                //            select customer;

                // No Lazy Loading
                var query = context.Customers
                    .Where(customer =>
                        customer.CustomerAddresses
                        .Any(ca => ca.Address.StateProvince == "Washington"))
                    //.Include(cust => cust.CustomerAddresses.Select(ca => ca.Address));
                    .Include("CustomerAddresses.Address");

                foreach (var cust2 in query)
                {
                    Console.WriteLine($"{cust2.CustomerID} {cust2.FirstName} {cust2.LastName}");
                    foreach (var address in cust2.CustomerAddresses)
                    {
                        Console.WriteLine($"     {address.Address.AddressLine1} {address.Address.StateProvince} {address.Address.CountryRegion}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
