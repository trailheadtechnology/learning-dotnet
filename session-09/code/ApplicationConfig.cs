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
