using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    internal class Loops
    {
        public void Main()
        {
            //for
            var myArray = new string[] { "a", "b", "c" };
            for (int i = 0; i < myArray.Length; i++)
            {
                var item = myArray[i];
                Console.WriteLine(item);
            }

            //while
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            //foreach
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            //do...while - DON'T USE THIS ONE
            x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 10);

            //break

            //continue
        }
    }
}
