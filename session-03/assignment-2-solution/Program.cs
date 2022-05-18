using System;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char key = ' ';

            while (key != 'x')
            {
                var d = new Dog();
                var c = new Cat();

                Console.WriteLine("Dog says " + d.Feed());
                Console.WriteLine("Cat says " + c.Feed());

                key = Console.ReadKey().KeyChar;
            }
        }
    }

    public abstract class Animal
    {
        protected int energy = 0;

        public abstract string Talk();

        public int GetEnergy()
        {
            return energy;
        }

        public virtual string Feed()
        {
            return Talk() + ", energy: " + energy;
        }
    }

    public class Dog : Animal
    {
        public override string Talk()
        {
            return "woof";
        }
        public override string Feed()
        {
            energy += 2; //same as: energy = energy + 2;
            return base.Feed();
        }
    }

    public class Cat : Animal
    {
        public override string Talk()
        {
            return "meow";
        }
        public override string Feed()
        {
            energy++; //same as: energy = energy + 1;
            return base.Feed();
        }
    }
}
