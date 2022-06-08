using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    public class CastingWithAs
    {
        public class Parent { }
        public class Child : Parent { }

        public void Main()
        {
            //casting = converting from a more specefic type to a less specific

            // narrowing conversion, requires a cast
            int i = Int16.MaxValue;
            short s = (short)i; // could get an exception here

            // expanding converstion will always work
            int j = s;

            // casting with 'as' keyword

            // not possible with value types
            //short s2 = i as short;

            // is possible with reference types (objects)
            var p = new Parent();
            Child c = p as Child;

            // comparing as to cast
            object x = "foo"; 
            string cast = (string)x; // could throw an InvalidCastException
            string asOperator = x as string; // will return null if it doesn't work
        }
    }
}
