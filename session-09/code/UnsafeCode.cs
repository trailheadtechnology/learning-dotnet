using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_09
{
    public class UnsafeCode
    {
        public unsafe static void Example()
        {
            fixed (char* value = "unsafe")
            {
                char* ptr = value;
                while (*ptr != '\0')
                {
                    Console.WriteLine(*ptr);
                    ++ptr;
                }
            }

            Console.ReadKey();
        }

        public static void Example2() //doesn't work without unsafe keyword
        {
            //int ab = 32;
            //int* p = &ab;
            //Console.WriteLine("value of ab is {0}", *p);
            //Console.ReadLine();
        }
    }
}
