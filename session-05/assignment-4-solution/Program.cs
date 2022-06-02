using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            var option = GetOption();

            while (option != 3)
            {
                Console.WriteLine();

                if (option == 3) return;

                Console.WriteLine(option == 1 ?
                    "Enter text to convert to Morse code:" :
                    "Enter Morse code to convert to text:");

                var textToConvert = Console.ReadLine();

                IConverter converter = (option == 1) ?
                    (IConverter)new TextToMorseConverter(textToConvert) :
                    (IConverter)new MorseToTextConverter(textToConvert);

                Console.WriteLine(converter.Convert());

                PrintMenu();
                option = GetOption();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Choose one:");
            Console.WriteLine("1) To convert text to Morse code");
            Console.WriteLine("2) To convert Morse code to text");
            Console.WriteLine("3) To exit");
        }

        private static int GetOption()
        {
            int? option = null;
            while (option == null)
            {
                var key = Console.ReadKey();

                if (key.KeyChar == '1') option = 1;
                else if (key.KeyChar == '2') option = 2;
                else if (key.KeyChar == '3') option = 3;
                else option = null;
            }

            return option.Value;
        }
    }
}
