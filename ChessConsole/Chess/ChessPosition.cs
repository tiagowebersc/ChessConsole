using System;
using Board;

namespace Chess
{
    class ChessPosition
    {
        public int row { get; set; }
        public char column { get; set; }

        public ChessPosition(char column, int row)
        {
            this.column = column;
            this.row = row;
        }


        public Position ToPosition()
        {
            return new Position(8 - row, column - 'A');
        }

        public override string ToString()
        {
            return "" + column + row;
        }
    }
}
