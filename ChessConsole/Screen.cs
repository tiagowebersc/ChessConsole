using System;
using Board;

namespace ChessConsole
 
{
    class Screen
    {
        public static void ShowBoard(ChessBoard board)
        {
            for (int i = 0; i < board.rows; i++)
            {
                Console.WriteLine("   ---------------------------------");
                Console.Write(" " + (8 - i) + " ");
                for (int j = 0; j < board.columns; j++)
                {
                    Console.Write("|");
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(" ");
                        ShowPiece(board.Piece(i, j));
                        Console.Write(" ");
        }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("   ---------------------------------");
            Console.WriteLine("     A   B   C   D   E   F   G   H  ");

        }

        public static void ShowPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor conColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = conColor;

            }
        }
    }
}
