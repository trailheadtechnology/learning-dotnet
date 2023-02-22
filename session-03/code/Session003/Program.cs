using System;

namespace Session003
{
    internal class Program
    {
        //members
        private int _i; //field

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

    //private - only the current class
    //protected - current class AND inheritance tree (derived classes)
    //internal - same project
    //public - everywhere
}
