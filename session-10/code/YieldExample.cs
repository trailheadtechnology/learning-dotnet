using System;
using System.Collections.Generic;

namespace session_10
{
    public class YieldExample
    {
        public static void Example()
        {
            var results = Fibonacci(10);
            foreach (int fib in results)
            {
                Console.WriteLine(fib);
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> Fibonacci(int n)
        {
            for (int i = 0, n1 = 0, n2 = 1; i < n; i++)
            {
                yield return n1;

                int temp = n1 + n2;
                n1 = n2;
                
                n2 = temp;
            }
        }
    }
}
