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
        public bool GetNextState(bool isCurrentAlive, int aliveCount)
        {
            return aliveCount == 3 || (aliveCount == 2 && isCurrentAlive);
        }
    }
}