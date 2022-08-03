using session_12.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            using (var context = new MyDbContext())
            {
                var customers = context.Customers.ToList();

                foreach (var c in customers)
                {
                    Console.WriteLine($"{c.CustomerID} {c.FirstName} {c.LastName}");
                }
            }
            Console.ReadKey();
        }
    }
}
