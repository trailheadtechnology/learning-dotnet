using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JSONNet.Example();
            JSONNet.Example();
            //MainAsync().GetAwaiter().GetResult();

            Console.ReadKey();
        }

        private static async Task MainAsync()
        {
            await HttpOptions.ExampleAsync();
        }
    }
}
