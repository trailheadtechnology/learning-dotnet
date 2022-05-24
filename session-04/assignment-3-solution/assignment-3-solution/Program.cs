using System;

namespace assignment_3_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            // get max
            while (max <= 1)
            {
                Console.WriteLine("What's the maximum number you'd like to guess?");
                var maximum = Console.ReadLine();
                if (!int.TryParse(maximum, out max) || max <= 1)
                {
                    Console.WriteLine("Enter a valid integer greater than 1");
                }
            }

            // start game
            Console.WriteLine("Guess the number between 1 and " + max);
            var rnd = new Random();
            var answer = rnd.Next(1, max + 1);
            int guess = -1;

            // get guesses
            while (guess != answer)
            {
                var userEntry = Console.ReadLine();

               if (int.TryParse(userEntry, out guess))
                {
                    if (guess != answer)
                    {
                        Console.WriteLine("Too " + (guess > answer ? "high" : "low"));
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid integer between 1 and " + max);
                }
            }

            Console.WriteLine("You win!");
            Console.ReadKey();
        }
    }
}
