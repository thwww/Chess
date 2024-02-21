
using Board;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                chessMatch math = new chessMatch();

                while (!math.finished)
                {
                    Console.Clear();
                    Screen.printBoard(math.tab);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPosition().toPosition();

                    bool[,] possiblePositions = math.tab.part(origin).possibleMovements();

                    Console.Clear();
                    Screen.printBoard(math.tab, possiblePositions);

                    Console.Write("Destiny: ");
                    Position destiny = Screen.readChessPosition().toPosition();

                    math.performMovement(origin, destiny);
                }
            } 
            catch (BoardException e) {
            Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}