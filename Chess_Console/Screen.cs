using System;
using Board;
using chess;

namespace Chess_Console
{
    internal class Screen
    {
        public static void printBoard(board tab)
        {
            for (int i = 0; i<tab.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                { 
                    printPart(tab.part(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printBoard(board tab, bool[,] possiblePositions)
        {
            ConsoleColor originalBackground = Console.BackgroundColor;
            ConsoleColor changedBackground = ConsoleColor.DarkGray;


            for (int i = 0; i < tab.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = changedBackground;
                    } else
                    {
                        Console.BackgroundColor = originalBackground;
                    }
                    printPart(tab.part(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalBackground;
        }

        public static chessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new chessPosition(column, line);
        }

        public static void printPart(Part part) {

            if (part == null)
            {
                Console.Write("- ");
            }
            else
            {

                if (part.color == Color.White)
                {
                    Console.Write(part);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(part);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
