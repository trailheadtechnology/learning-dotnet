using System;

namespace Session003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var o = new Sample2();

            int x = 12;
            int y; //defaults to 0

            Console.WriteLine(x);
            Console.WriteLine("Increment worked: " + o.TryToIncrement(x, out y));
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
