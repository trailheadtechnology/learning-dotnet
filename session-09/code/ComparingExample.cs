using System.Collections.Generic;

namespace session_09
{
    public class IComparerExample
    {
        public static void Example()
        {
            var people = new List<Person> {
                new Person { Age = 23, Name="Older" },
                new Person { Age = 22, Name="Younger" }
            };

            people.Sort(new AgeComparer());
        }
    }

    class Person
    {
        public int Age;
        public string Name;
    }

    class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
