﻿using System;
using Board;

namespace ChessConsole
 
{
    class Screen
    {
        public static void showBoard(ChessBoard board)
        {
            for (int i = 0; i < board.rows; i++)
            {
                for (int j = 0; j < board.columns; j++)
                {
                    if (j > 0 && j < board.columns) Console.Write(" ");
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(" " + board.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }


        }
    }
}