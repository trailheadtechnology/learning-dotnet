using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_09
{
    public class ComparingExample
    {
        public static void Example()
        {
            // Create an array of Car objects.
            Car[] arrayOfCars = new Car[6]
            {
             new Car("Ford",1992),
             new Car("Fiat",1988),
             new Car("Buick",1932),
             new Car("Ford",1932),
             new Car("Dodge",1999),
             new Car("Honda",1977)
            };

            // Write out a header for the output.
            Console.WriteLine("Array - Unsorted\n");

            foreach (Car c in arrayOfCars)
                Console.WriteLine(c.Make + "\t\t" + c.Year);

            // Demo IComparable by sorting array with "default" sort order.
            Array.Sort(arrayOfCars);
            Console.WriteLine("\nArray - Sorted by Make (Ascending - IComparable)\n");

            foreach (Car c in arrayOfCars)
                Console.WriteLine(c.Make + "\t\t" + c.Year);

            // Demo ascending sort of numeric value with IComparer.
            Array.Sort(arrayOfCars, Car.SortYearAscending());
            Console.WriteLine("\nArray - Sorted by Year (Ascending - IComparer)\n");

            foreach (Car c in arrayOfCars)
                Console.WriteLine(c.Make + "\t\t" + c.Year);
            
            // Demo descending sort of string value with IComparer.
            Array.Sort(arrayOfCars, Car.SortMakeDescending());
            Console.WriteLine("\nArray - Sorted by Make (Descending - IComparer)\n");

            foreach (Car c in arrayOfCars)
                Console.WriteLine(c.Make + "\t\t" + c.Year);

            // Demo descending sort of numeric value using IComparer.
            Array.Sort(arrayOfCars, Car.SortYearDescending());
            Console.WriteLine("\nArray - Sorted by Year (Descending - IComparer)\n");

            foreach (Car c in arrayOfCars)
                Console.WriteLine(c.Make + "\t\t" + c.Year);

            Console.ReadLine();
        }
    }

    public class Car : IComparable
    {
        private int year;
        private string make;
        public Car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        // Beginning of nested classes.
        // Nested class to do ascending sort on year property.
        private class SortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year > c2.year)
                    return 1;

                if (c1.year < c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on year property.
        private class SortYearDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year < c2.year)
                    return 1;

                if (c1.year > c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on make property.
        private class SortMakeDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;
                return String.Compare(c2.make, c1.make);
            }
        }
        // End of nested classes.

        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            Car c = (Car)obj;
            return String.Compare(this.make, c.make);
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortYearAscending()
        {
            return (IComparer)new SortYearAscendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortYearDescending()
        {
            return (IComparer)new SortYearDescendingHelper();
        }
      
        // Method to return IComparer object for sort helper.
        public static IComparer SortMakeDescending()
        {
            return (IComparer)new SortMakeDescendingHelper();
        }

    }
}
