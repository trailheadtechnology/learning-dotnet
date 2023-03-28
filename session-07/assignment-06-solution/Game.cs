namespace ConwaysGameOfLife
{
    public class Game
    {
        private const int COLS = 80;
        private const int ROWS = 24;
        private const char GERM = '\u2588';
        private const char EMPTY = ' ';
      
        private State[,] grid;

        public Game(State[,] initialState)
        {
            grid = initialState;
        }

        public Game()
        {
            grid = new State[ROWS, COLS];

            // Initialize the grid randomly
            var rnd = new Random();
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    grid[i, j] = (rnd.Next(0, 6) == 0 ? State.Alive : State.Dead);
                }
            }
        }

        public void Play()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;

            // game loop
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                
                DrawGrid(grid);

                grid = ApplyRules(grid);

                Thread.Sleep(50);
            }
        }

        private State[,] ApplyRules(State[,] currentGrid)
        {
            var newGrid = new State[ROWS, COLS];

            for (var i = 0; i < ROWS; i++)
            {
                for (var j = 0; j < COLS; j++)
                {
                    var neighbors = GetNeighborCount(currentGrid, i, j);

                    // rule 1: Any live cell with fewer than two live neighbors dies as if caused by under-population (DEFAULTED to 0)
                    // rule 3: Any live cell with more than three live neighbors dies, as if by over-population (DEFAULTED to 0)

                    if (currentGrid[i, j] == State.Alive && (neighbors == 2 || neighbors == 3))
                    {
                        // rule 2: Any live cell with two or three live neighbors lives on to the next generation
                        newGrid[i, j] = State.Alive;
                    }
                    else if (currentGrid[i, j] == State.Dead && neighbors == 3)
                    {
                        // rule 4: Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction
                        newGrid[i, j] = State.Alive;
                    }
                }
            }
            return newGrid;
        }

        private void DrawGrid(State[,] currentGrid)
        {
            for (var i = 0; i < ROWS; i++)
            {
                for (var j = 0; j < COLS; j++)
                {
                    Console.Write(currentGrid[i, j] == State.Alive ? GERM : EMPTY);
                }
                Console.WriteLine();
            }
        }

        private int GetNeighborCount(State[,] currentGrid, int x, int y)
        {
            var count = 0;
            for (var xDiff = -1; xDiff <= 1; xDiff++)
            {
                for (var yDiff = -1; yDiff <= 1; yDiff++)
                {
                    var neighborX = x + xDiff;
                    var neighborY = y + yDiff;

                    if (xDiff == 0 && yDiff == 0)
                    {
                        // Skip the cell itself
                        continue;
                    }
                    else if (neighborX < 0 || neighborX >= ROWS || neighborY < 0 || neighborY >= COLS)
                    {
                        // Out of bounds
                        continue;
                    }

                    count += (int)currentGrid[neighborX, neighborY];
                }
            }
            return count;
        }

    }
}
