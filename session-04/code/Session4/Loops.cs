using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
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
            var j = 0;
            while (true) // goes forever
            {
                var userEntry = Console.ReadLine();
                j = int.Parse(userEntry);

                if (j > 0)
                {
                    Console.WriteLine("You entered a positive number");
                }    
                else if (j < 0)
                {
                    Console.WriteLine("You entered a negative number");
                }
                else
                {
                    // value is exactly zero
                    break;
                }
            }

            //continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue; //iter in rpg
                }
                Console.WriteLine(i);
            }
            //0 1 2 3 5 6 7 8 9
        }
    }
}
