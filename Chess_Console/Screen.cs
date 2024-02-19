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
                    if (tab.part(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printPart(tab.part(i, j));
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static chessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new chessPosition(column, line);
        }

        public static void printPart(Part part) { 
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
        }
    }
}
