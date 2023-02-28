using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session4.EnumsAndStrucs;

namespace Session4
{
    public struct Temperature
    {
        public double Value { get; set; }
        public TemperatureScale Scale { get; set; }
    }

    public struct Square
    {
        public int side;

        public int Area()
        {
            return side * side;
        }
    }

    //public class Cooridate
    public struct Cooridate
    {
        public int X;
        public int Y;

        public Cooridate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsOrigin()
        {
            return X == 0 && Y == 0;
        }
    }

    internal class StructExamples
    {
        public void Main()
        {
            // no constructor
            Cooridate c;
            c.X = 1;
            c.Y = 2;

            // constructor
            var coor = new Cooridate(1, 2);
            if (coor.IsOrigin())
            {
                Console.WriteLine("origin");
            }
        }
    }
}
