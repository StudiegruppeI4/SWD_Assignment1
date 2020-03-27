namespace ChessWithCommandPattern
{
    public class MovePawnCommand : Command
    {
        private Pawn _pawn;

        public MovePawnCommand(Piece pawn)
        {
            _pawn = (Pawn)pawn;
        }

        public void Execute()
        {
            _pawn.Move();
        }

        public void Undo()
        {
            _pawn.Undo();
        }
    }
}