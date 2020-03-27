namespace ChessWithCommandPattern
{
    public class MoveKnightCommand : Command
    {
        private Knight _knight;

        public MoveKnightCommand(Piece knight)
        {
            _knight = (Knight)knight;
        }

        public void Execute()
        {
            _knight.Move();
        }

        public void Undo()
        {
            _knight.Undo();
        }
    }
}