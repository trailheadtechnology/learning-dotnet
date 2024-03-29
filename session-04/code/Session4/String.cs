﻿using System;
using System.Text;

namespace Session4
{
    internal class String2
    {
        public class SampleClass
        {
            public string Name { get; set; } = "J.";

            public override string ToString()
            {
                return $"{{ \"Name\" = \"{Name}\" }}"; // { "Name" = "J." }
            }
        }

        public void Main()
        {
            string s = "Call me \"J\".";
            string name = "J. Tower";
            string s2 = $"Call me {name}";

            Console.WriteLine(s); //Call me "J".

            string x = @"
                <h2 style=""bold"">
                asdf

                            asdf

                Hello, world!
                ";

            int numGuesses = 10;
            int seconds = 60;
            int correctAnswer = 5;

            // be careful with the meaning of +
            var value = "" + seconds + 60 + " seconds";
            var value2 = $"{seconds + 60 - numGuesses}60 seconds";

            string greeting = "It took you " + seconds + " seconds and " 
                + numGuesses + " guesses to guess the correct answer: " 
                + correctAnswer;

            string y = $"It took you {seconds:S4} seconds and {numGuesses} guesses to guess the"
                + $" correct answer: {correctAnswer}";
            //It took you 60 seconds and 10 guesses to guess the correct answer: 5

            string w = string.Format("It took you {0:G2} seconds and {1} guesses to guess the correct answer: {2}", 
                seconds, numGuesses, correctAnswer); //60.00

            string z = $@"It took you {seconds:0000} seconds and {numGuesses} guesses to guess the
                            correct answer: {correctAnswer}";

            //It took you 60 seconds and 10 guesses to guess the
            //                                correct answer: 5

            int i = 10;
            i.ToString("0000"); //"10"
            i.ToString("G2"); //"10.00"

            float f = 4.55555f;
            f.ToString(); //"4.55555"

            var sc = new SampleClass();
            sc.ToString(); //"{ "Name" = "J." }"

            //immutable value
            string j = ""; //old
            j = j + "adf"; //new

            // build an HTML file as a string
            // more efficient and clean way to build large strings
            StringBuilder sb = new StringBuilder("Hello, ");
            sb.Append(name);
            sb.AppendLine();
            sb.ToString();
        }
    }
}
