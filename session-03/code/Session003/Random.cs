using System;

namespace Session003
{
    internal class RandomExample
    {
        public void Main()
        {
            var rnd = new Random();
            var myRandomNumber = rnd.Next(1, 11); //generates a int from 1 to 10
        }
    }
}
