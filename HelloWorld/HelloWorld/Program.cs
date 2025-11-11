// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("■◻");
        }
    }

    public class Conway
    {
        public const int SIZE = 4;
        public bool[,] board = new bool[SIZE, SIZE];

        public bool GetNextState(bool isCurrentAlive, int aliveCount)
        {
            return aliveCount == 3 || (aliveCount == 2 && isCurrentAlive);
        }

        public int GetAliveNeighboursCount(int x, int y)
        {
            int count = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 0 || i > SIZE || j < 0 || j > SIZE || (i == x && j == y)) continue;
                    if (board[i, j]) count++;
                }
            }
            return count;
        }

    }
}