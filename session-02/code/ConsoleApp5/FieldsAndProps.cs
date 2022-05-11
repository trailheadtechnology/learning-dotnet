using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FieldsAndProps
{
    internal class Person
    {
        private string _name; //field, looks like a variable in the class

        public Person(String name) //constructor with one param
        {
            //initializes the Person object instance
            _name = name;
        }
       
        public void Introduce()
        {
            Console.WriteLine("My name is " + _name);
        }
    }

    internal class MyConsumerClass
    {
        public void Main()
        {
            Person p1 = new Person("J. Tower");
            p1.Introduce();

            Person p2 = new Person("Chris");
            p2.Introduce();
        }
    }
}
