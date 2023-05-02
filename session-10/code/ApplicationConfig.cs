using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_09
{
    public class ApplicationConfig
    {
        //public static void ExampleDeprecated()
        //{
        //    var appSetting1 = ConfigurationManager.AppSettings["appSetting1"];
        //    Console.WriteLine(appSetting1);

        //    var myConnectionString1 = ConfigurationManager.ConnectionStrings["myConnectionString1"];
        //    Console.WriteLine($"{myConnectionString1.ProviderName} {myConnectionString1.ConnectionString}");

        //    Console.ReadKey();
        //}

        public static void Example()
        {
            var envName = "Development";

            // load the configuration file.
            var configBuilder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               //.AddJsonFile($"appsettings.{envName}.json")
               //...environment variables, key vault in AWS or Azure
               .Build();

            // get the section to read
            var configSection = configBuilder.GetSection("AppSettings");

            // get the configuration values in the section.
            var client_id = configSection["client_id"] ?? null;
            var client_secret = configSection["client_secret"] ?? null;

            Console.WriteLine($"{client_id} {client_secret}");
        }
    }
}
