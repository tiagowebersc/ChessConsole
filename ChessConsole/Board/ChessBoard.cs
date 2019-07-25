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

    }
}
