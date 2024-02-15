
using Board;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            board tab = new board(8, 8);

            tab.placePart(new Castle(tab, Color.Black), new Position(0, 0));
            tab.placePart(new Castle(tab, Color.Black), new Position(1, 3));
            tab.placePart(new King(tab, Color.Black), new Position(2, 4));

            Screen.printBoard(tab);

            Console.ReadLine();
        }
    }
}