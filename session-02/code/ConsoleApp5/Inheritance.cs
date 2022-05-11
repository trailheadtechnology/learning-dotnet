using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Snack
    {
        public int calories;
    }

    public class Cake : Snack
    {
        public int pieces;
        public bool isChocolate;
    }

    public class Chips : Snack
    {
        public bool fromCan;
        public bool fromBag;
    }

    internal class MyConsumerClass2
    {
        public void Main()
        {
            Chips c = new Chips();
            c.fromCan = true;
            c.fromBag = false;
            c.calories = 1000;

            Cake cake = new Cake();
            cake.isChocolate = true;
            cake.calories = 5000;
        }
    }
}
