using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_09
{
    public class Tuples
    {
        public static void Example()
        {
            // simple example
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            var xs = new[] { 4, 7, 9 };
            var limits = FindMinMax(xs);
            Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
            // Output:
            // Limits of [4 7 9] are 4 and 9

            var ys = new[] { -9, 0, 67, 100 };
            var (minimum, maximum) = FindMinMax(ys);
            Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
            // Output:
            // Limits of [-9 0 67 100] are -9 and 100
        }

        public static (int min, int max) FindMinMax(int[] input)
        {
            if (input is null || input.Length == 0)
            {
                throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
            }

            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var i in input)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }

            return (min, max);
        }
    }
}
