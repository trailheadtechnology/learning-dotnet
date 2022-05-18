using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003.Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            //todo
        }
    }

    public class Biped
    {

    }

    public interface INameable
    {
        string Name { get; set; }  
    }

    public class Person : Animal, INameable//, Biped <-- no multiple inheritance
    {
        public string Name { get; set; }  
    }

    public class Dog : Animal, INameable
    {
        public string Name { get; set; }
    }

    public class Worm : Animal
    {
    }

    public class Sample
    {
        public void Main()
        {
            var p = new Person();
            p.Eat();
            SayHi(p);

            var d = new Dog();
            d.Eat();
            SayHi(d);

            var w = new Worm();
            w.Eat();
            SayHi(w);
        }

        public void SayHi(INameable nameable)
        {
            Console.WriteLine("Hello, " + nameable.Name);
        }
    }
}
