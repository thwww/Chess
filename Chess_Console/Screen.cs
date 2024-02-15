using System;
using Board;

namespace Chess_Console
{
    internal class Screen
    {
        public static void printBoard(board tab)
        {
            for (int i = 0; i<tab.lines; i++)
            {
                for (int j = 0; j < tab.columns; j++)
                {
                    if (tab.part(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.part(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
