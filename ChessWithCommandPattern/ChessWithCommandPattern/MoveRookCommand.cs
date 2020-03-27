namespace ChessWithCommandPattern
{
    public class MoveRookCommand : Command
    {
        private Rook _rook;

        public MoveRookCommand(Piece rook)
        {
            _rook = (Rook)rook;
        }

        public void Execute()
        {
            _rook.Move();
        }

        public void Undo()
        {
            _rook.Undo();
        }
    }
}