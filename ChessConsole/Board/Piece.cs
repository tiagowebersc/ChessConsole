namespace Board
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int totalMoves { get; protected set; }
        public ChessBoard board { get; protected set; }

        public Piece (ChessBoard board, Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            this.totalMoves = 0;
        }
    }
}
