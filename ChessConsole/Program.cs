using System;
using Board;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessBoard board = new ChessBoard(8, 8);
                board.InsertPiece(new King(board, Color.White), new Position(0, 0));
                board.InsertPiece(new Rook(board, Color.White), new Position(4, 6));

                Screen.showBoard(board);

                ChessPosition cp = new ChessPosition('D', 3);
                Console.WriteLine(cp);
                Console.WriteLine(cp.ToPosition());
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
