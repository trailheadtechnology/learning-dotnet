using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Person
    {
        public Person() //constructor with no params
        {
        }
        public Person(String name) //constructor with one param
        {
            //initializes the Person object instance
            Console.WriteLine(name);
        }
        public Person(String firstName, String middleName, String lastName) //constructor with two params
        {
        }
        public Person(int age) //constructor with one param
        {
        }
    }

    internal class MyConsumerClass
    {
        public void Main()
        {
            Person p = new Person("", "", "");
        }
    }
}
