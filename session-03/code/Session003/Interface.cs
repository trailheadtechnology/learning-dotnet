using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session003
{
    public interface IDriveable 
    {
        void Drive();
    }

    public class Car : IDriveable
    {
        public void Stear()
        {

        }
        public void Drive()
        {
            
        }
    }

    public class Train : IDriveable
    {
        public void LinkUp()
        {

        }
        public void Drive()
        {

        }
    }

    internal class Interface
    {
        public void Main()
        {
            var t = new Train();
            DoDrive(t);

            var c = new Car();
            DoDrive(c);
        }

        public void DoDrive(IDriveable driveable)
        {
            driveable.Drive();
            
            if (driveable is Car)
            { 
                ((Car)driveable).Stear();
            }

            if (driveable is Train)
            {
                ((Train)driveable).LinkUp();
            }
        }
    }

    public interface INameable
    {
        string Name { get; set; }
    }

    public class Person2 : INameable
    {
        public string Name { get; set; }
    }

    public class Dog : INameable
    {
        public string Name { get; set; }
    }
}
