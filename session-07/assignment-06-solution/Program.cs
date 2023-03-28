using System;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main()
        {
            Game g;

            Console.WriteLine("Type a filename or hit ENTER to start random");
            var fileName = Console.ReadLine();

            if (fileName.Length == 0)
            {
                g = new Game();
            }
            else
            {
                var initalState = ReadInput(fileName);
                g = new Game(initalState);
            }

            g.Play();
        }

        static State[,] ReadInput(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            // Create a two-dimensional int array to store the grid
            int rows = lines.Length;
            int cols = lines[0].Length;
            State[,] grid = new State[rows, cols];

            // Convert the text into a grid of 0s and 1s
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = (lines[i][j] == '.') ? State.Dead : State.Alive;
                }
            }

            return grid;
        }
    }
}