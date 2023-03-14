using System;

class Hangman
{
    static void Main(string[] args)
    {
        // Set up the game
        string[] words = { "cat", "dog", "bird", "horse", "elephant" };
        string word = words[new Random().Next(0, words.Length)];
        int numGuesses = 6;
        bool[] guessedLetters = new bool[26];

        // Play the game
        Console.WriteLine("Welcome to Hangman!");

        while (true)
        {
            // Display the hangman graphic
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(GetHangmanGraphic(numGuesses));
            Console.ForegroundColor = ConsoleColor.White;

            // Display the current state of the game
            Console.WriteLine();
            Console.Write("Word: " );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GetDisplayWord(word, guessedLetters));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guesses remaining: " + numGuesses);

            // Check for a win or loss
            if (GetDisplayWord(word, guessedLetters) == word)
            {
                Console.WriteLine("Congratulations, you win!");
                break;
            }
            else if (numGuesses == 0)
            {
                Console.WriteLine("Sorry, you lose! The word was: " + word);
                break;
            }

            // Get the player's guess
            Console.Write("Guess a letter or the whole word: ");
            string guess = Console.ReadLine().ToLower();

            // Check if the guess is valid
            if (guess.Length == 0 || guess.Length > word.Length)
            {
                Console.WriteLine("Invalid guess! Please enter a valid letter or the entire word.");
                continue;
            }
            if (guess.Length == word.Length && guess == word)
            {
                Console.WriteLine("Congratulations, you win!");
                break;
            }
            if (guessedLetters[guess[0] - 'a'])
            {
                Console.WriteLine("You already guessed that letter!");
                continue;
            }

            // Process the guess
            if (guess.Length == 1)
            {
                guessedLetters[guess[0] - 'a'] = true;
                if (word.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    numGuesses--;
                }
            }
            else if (guess == word)
            {
                Console.WriteLine("Congratulations, you win!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect!");
                numGuesses--;
            }
        }
    }

    static string GetDisplayWord(string word, bool[] guessedLetters)
    {
        string display = "";
        foreach (char c in word)
        {
            if (guessedLetters[c - 'a'])
            {
                display += c;
            }
            else
            {
                display += "_";
            }
        }
        
        return display;
    }

    static string GetHangmanGraphic(int numGuesses)
    {
        string[] hangmanGraphics = {
        "",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|        /|\\\n" +
        "|        / \\\n" +
        "|\n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|        /|\\\n" +
        "|        / \n" +
        "|\n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|        /|\\\n" +
        "|          \n" +
        "|          \n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|        /|\n" +
        "|          \n" +
        "|          \n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|         |\n" +
        "|          \n" +
        "|          \n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|         O\n" +
        "|          \n" +
        "|          \n" +
        "|          \n" +
        "|\n",
        " _________\n" +
        "|         |\n" +
        "|          \n" +
        "|          \n" +
        "|          \n" +
        "|          \n" +
        "|\n"
    };

        return hangmanGraphics[numGuesses];
    }
}