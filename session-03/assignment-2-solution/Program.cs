using System;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char key = ' ';
            var d = new Dog(2, 4);
            var c = new Cat(1, 2);

            while (key != 'x')
            {
                Console.WriteLine("Dog says " + d.Feed());
                Console.WriteLine("Cat says " + c.Feed());

                key = Console.ReadKey().KeyChar;
            }
        }
    }

    public abstract class Animal
    {
        protected int _energy = 0;
        protected int _incrementBy = 1;

        public Animal(int energy, int incrementBy)
        {
            _energy = energy;
            _incrementBy = incrementBy;
        }

        public abstract string Talk();

        public int GetEnergy()
        {
            return _energy;
        }

        public virtual string Feed()
        {
            return Talk() + ", energy: " + _energy;
        }
    }

    public class Dog : Animal
    {
        public Dog(int energy, int incrementBy) : base(energy, incrementBy) { }

        public override string Talk()
        {
            return "woof";
        }
        public override string Feed()
        {
            _energy += _incrementBy; //same as: energy = energy + 2;
            return base.Feed();
        }
    }

    public class Cat : Animal
    {
        public Cat(int energy, int incrementBy) : base(energy, incrementBy) { }

        public override string Talk()
        {
            return "meow";
        }
        public override string Feed()
        {
            _energy += _incrementBy; //same as: energy = energy + 1;
            return base.Feed();
        }
    }
}
