using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    internal class Arithmetic
    {
        public void Main()
        {
            int i = 1;
            int j = 2;

            int k = i + j;
            //string s = "first part " + "second part";

            //increment
            i++; //i = i + 1;
            i += 2; // i = i +2
            i += j;

            //decrement
            i--; // i = i - 1;
            i -= 2;
            i -= j;

            // order of operations?
            i = 10 * 20 + 4;
            i = ((10 * 20) + 4) * 2;
        }
    }
}
