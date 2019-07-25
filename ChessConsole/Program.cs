using System;
using Board;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard(8,8);
            board.AddPiece(new King(board, Color.White), new Position(0, 0));
            board.AddPiece(new Rook(board, Color.White), new Position(4, 6));

            Screen.showBoard(board);
            Console.ReadLine();
        }
    }
}
