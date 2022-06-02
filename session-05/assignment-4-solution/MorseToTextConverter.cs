using System;
using System.Text;

namespace assignment_4_solution
{
    public class MorseToTextConverter : IConverter
    {
        private readonly string _morseCodeToConvert;
        private const char DOT = '.';
        private const char DASH = '−';
        private readonly char[] AlphaNumeric = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r','s', 't', 'u', 'v', 'w', 'x', 'y',
            'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private readonly string[] MorseCodes = { " .-", " -...", " -.-.", " -..", " .", " ..-.",
            " --.", " ....", " ..", " .---", " -.-", " .-..", " --", " -.", " ---", " .--.", " --.-", " .-.", " ...",
            " -", " ..-", " ...-", " .--", " -..-", " -.--", " --..", " .----", " ..---", " ...--", " ....-",
            " .....", " -....", " --...", " ---..", " ----.", " -----" };

        public MorseToTextConverter(string morseCodeToConvert)
        {
            _morseCodeToConvert = morseCodeToConvert;
        }

        public string Convert()
        {
            StringBuilder sb = new StringBuilder();

            var morseChars = _morseCodeToConvert.Split(' ');
            foreach (string currentChar in morseChars)
            {
                var index = Array.IndexOf(MorseCodes, " " + currentChar.Trim());
                if (index >= 0)
                {
                    sb.Append(AlphaNumeric[index]);
                }
            }

            return sb.ToString();
        }
    }
}
