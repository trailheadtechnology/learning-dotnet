using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var result = await WeatherAlerts.GetAlertsAsync();

            foreach (var alert in result.features)
            {
                Console.WriteLine(alert.properties.description);
            }

            Console.ReadKey();
        }
    }
}
