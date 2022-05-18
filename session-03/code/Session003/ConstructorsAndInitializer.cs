using System;

namespace Session003
{
    public class Person
    {
        public string name;
        public string homeTown;
        protected int age; //field

        public Person(int initialAge) //constructor, called when you use "new"
        {
            age = initialAge;
        }
        public Person(int initialAge, string initialName, string initialHomeTown) //constructor, called when you use "new"
        {
            age = initialAge;
            homeTown = initialHomeTown;
            name = initialName;
        }
    }

    public class Programmer : Person
    {
        public Programmer() : base(30)
        {
            age = 27;
        }
    }

    public class CallingClass
    {
        public void Main()
        {
            Person mySampleClass = new Person(24); //instantiating
        }
    }

    public class CallingClass2
    {
        public void Main()
        {
            Person mySampleClass = new Person(25);
            // right here before the value are set
            mySampleClass.name = "J. Tower";
            mySampleClass.homeTown = "Grand Rapids";
            //...

            //some other code
            Person mySampleClass2 = new Person(25) { 
                name = "J. Tower", 
                homeTown = "Grand Rapids" 
            };
            //some other code

            // constructor only
            var mySampleClass3 = new Person(25, "J. Tower", "Grand Rapids");
        }
    }
}
