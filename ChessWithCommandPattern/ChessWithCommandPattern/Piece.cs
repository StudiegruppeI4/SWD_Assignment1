namespace ChessWithCommandPattern
{
    public interface Piece
    {
        void Move();
        void Undo();
    }
}