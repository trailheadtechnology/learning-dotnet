using System;
using System.Linq;

namespace session_11
{
    public class UpdateExample
    {
        public static void Example()
        {
            using (var context = new AdventureWorksEntities())
            {
                // update single
                var cust = context.Customers
                    .Where(c => c.CustomerID == 1)
                    .FirstOrDefault();

                //// skip and take
                //var customers = context.Customers.OrderBy(i => i.CustomerID); //.ToList();
                //var count = customers.Count();
                //for (int i = 0; i < count; i+=10)
                //{
                //    foreach (var c in customers.Skip(i).Take(10))
                //    {

                //    }
                //}

                Console.WriteLine($"{cust.CustomerID} {cust.FirstName} {cust.LastName}");
                Console.ReadKey();

                cust.FirstName += "1";
                //// SAME AS:
                // cust.FirstName = cust.FirstName + "1";
                Console.WriteLine($"{cust.CustomerID} {cust.FirstName} {cust.LastName}");
                
                var effected = context.SaveChanges();
                Console.WriteLine($"{effected} rows updated");
                Console.ReadKey();

                // update many
                var query = from address in context.Addresses
                            where address.StateProvince == "Washington"
                                && (address.CountryRegion == "US"
                                    || address.CountryRegion == "United States")
                            select address;

                foreach (var addr in query) // IQueryable vs IEnumerable
                {
                    Console.WriteLine($"{addr.StateProvince} {addr.CountryRegion}");
                    if (addr.CountryRegion == "United States")
                    {
                        addr.CountryRegion = "US";
                    }
                    else
                    {
                        addr.CountryRegion = "United States";
                    }
                }
                effected = context.SaveChanges();
                Console.WriteLine($"{effected} rows updated");
                Console.ReadKey();

                foreach (var addr in query) // IQueryable vs IEnumerable
                {
                    Console.WriteLine($"{addr.StateProvince} {addr.CountryRegion}");
                }
                Console.ReadKey();
            }
        }
    }
}
