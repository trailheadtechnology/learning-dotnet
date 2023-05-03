using Microsoft.EntityFrameworkCore;
using session_11.Data;
using System;
using System.Diagnostics;
using System.Linq;

namespace session_11
{
    public class NavigationProperties
    {
        public static void Example()
        {
            using (var context = new AdventureWorksContext())
            {
                //context.Database.Log = s => Debug.WriteLine(s);
                //context.Configuration.LazyLoadingEnabled = false;

                //// BEWARE of LazyLoading
                //var query = from customer in context.Customers
                //            where customer.CustomerAddresses.Any(ca => ca.Address.StateProvince == "Washington")
                //            select customer;

                // No Lazy Loading
                var query = context.Customers
                    .Include(cust => cust.CustomerAddresses).ThenInclude(ca => ca.Address)
                    //.Include("CustomerAddresses.Address")
                    .Where(customer =>
                        customer.CustomerAddresses
                        .Any(ca => ca.Address.StateProvince == "Washington"))
                    ;

                foreach (var cust2 in query)
                {
                    Console.WriteLine($"{cust2.CustomerId} {cust2.FirstName} {cust2.LastName}");
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
