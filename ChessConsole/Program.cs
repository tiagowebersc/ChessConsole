using System;
using Board;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard b = new ChessBoard(8,8);

            Screen.showBoard(b);
            Console.ReadLine();
        }
    }
}
