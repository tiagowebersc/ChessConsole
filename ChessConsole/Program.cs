using System;
using Board;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard b = new ChessBoard(8,8);

            Position p = new Position(3, 4);

            Console.WriteLine("Position: " + p);
            Console.ReadLine();
        }
    }
}
