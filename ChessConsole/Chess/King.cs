using Board;

namespace Chess
{
    class King : Piece
    {
        public King (ChessBoard board, Color color) : base (board, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
