using System;
using Board;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            chessPosition pos = new chessPosition('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosition());


            Console.ReadLine();
        }
    }
}