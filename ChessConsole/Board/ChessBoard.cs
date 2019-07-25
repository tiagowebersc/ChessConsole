namespace Board
{
    class ChessBoard
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public ChessBoard(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.pieces = new Piece[rows, columns];
        }

        public Piece Piece(int row, int column)
        {
            return pieces[row, column];
        }

        public Piece Piece (Position position)
        {
            return pieces[position.row, position.column];
        }

        public bool IsTherePiece(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void InsertPiece(Piece piece, Position position)
        {
            if (IsTherePiece(position))
                throw new BoardException("There is one piece in this position!");

            pieces[position.row, position.column] = piece;
            piece.position = position;
        }

        public bool ValidPosition(Position position)
        {
            if (position.row    <  0    ||
                position.column <  0    ||
                position.row    >= rows ||
                position.column >= columns)
                return false;
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
