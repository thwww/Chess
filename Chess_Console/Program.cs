
using Board;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            board tab = new board(8, 8);

            tab.placePart(new Castle(tab, Color.Black), new Position(0, 0));
            tab.placePart(new Castle(tab, Color.Black), new Position(1, 3));
            tab.placePart(new King(tab, Color.Black), new Position(0, 2));

            tab.placePart(new Castle(tab, Color.White), new Position(3, 5));

            Screen.printBoard(tab);
            } 
            catch (BoardException e) {
            Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}