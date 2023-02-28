using Session4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Session4
{
    internal class Casting
    {
        public void Main()
        {
            // implicit casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // explicit casting
            myDouble = 9.78;
            myInt = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            //Convert class
            myInt = 10;
            myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            //widening and narrowing conversions
            int i = 1;
            double d;
            d = i; //widening
            i = (int)d; //narrowing, must be explicit

            //casting vs using 'as'
            object x = "foo"; //works
            //object x = 1; //throws exception without 'as'
            string cast = (string)x;
            string asOperator = x as string;
        }
    }

    public class Shape { }
    public class Circle : Shape { }
}
