using System;
using System.Configuration;

namespace session_10
{
    public class ApplicationConfig
    {
        public static void Example()
        {
            var appSetting1 = ConfigurationManager.AppSettings["appSetting1"];
            Console.WriteLine(appSetting1);
         
            var myConnectionString1 = ConfigurationManager.ConnectionStrings["myConnectionString1"];
            Console.WriteLine($"{myConnectionString1.ProviderName} {myConnectionString1.ConnectionString}");

            Console.ReadKey();
        }
    }
}
