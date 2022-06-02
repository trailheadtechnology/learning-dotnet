using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_solution
{
    public class TextToMorseConverter : IConverter
    {
        private readonly string _textToConvert;
        private const char DOT = '.';
        private const char DASH = '−';
        private readonly char[] AlphaNumeric = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r','s', 't', 'u', 'v', 'w', 'x', 'y',
            'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private readonly string[] MorseCodes = { " .-", " -...", " -.-.", " -..", " .", " ..-.",
            " --.", " ....", " ..", " .---", " -.-", " .-..", " --", " -.", " ---", " .--.", " --.-", " .-.", " ...",
            " -", " ..-", " ...-", " .--", " -..-", " -.--", " --..", " .----", " ..---", " ...--", " ....-",
            " .....", " -....", " --...", " ---..", " ----.", " -----" };

        public TextToMorseConverter(string textToConvert)
        {
            _textToConvert = textToConvert;
        }

        public string Convert()
        {
            StringBuilder sb = new StringBuilder();

            foreach (char currentChar in _textToConvert)
            {
                var index = Array.IndexOf(AlphaNumeric, currentChar);
                if (index >= 0)
                {
                    sb.Append(MorseCodes[index]);
                }
            }

            return sb.ToString();
        }
    }
}
