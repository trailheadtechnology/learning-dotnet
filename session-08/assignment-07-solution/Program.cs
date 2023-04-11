using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var results = await WeatherAlerts.GetAlertsAsync("FL", "");

            foreach (var alert in results)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine(alert.Feature);
                Console.WriteLine();
                Console.WriteLine(alert.Description);
            }

            Console.ReadKey();
        }
    }
}
