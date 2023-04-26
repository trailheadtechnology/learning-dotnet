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

            people.Sort(new AgeComparer(false));
        }
    }

    class Person
    {
        public int Age;
        public string Name;
    }

    class AgeComparer : IComparer<Person>
    {
        private bool _asc;

        public AgeComparer(bool Asc)
        {
            _asc = Asc;
        }

        public int Compare(Person x, Person y)
        {
            if (_asc)
                return x.Age - y.Age;

            return y.Age - x.Age;
        }
    }
}
