using System;

namespace session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var example = new TryCatch();
                Console.WriteLine(example.Method1(15, 0));
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            Console.ReadKey();
        }
    }
}
