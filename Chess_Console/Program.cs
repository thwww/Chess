
using Board;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            board tab = new board(8, 8);

            Screen.printBoard(tab);

            Console.ReadLine();
        }
    }
}