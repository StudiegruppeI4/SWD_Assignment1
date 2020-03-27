using System.Collections.Generic;

namespace ChessWithCommandPattern
{
    public class Player
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void MakeMove()
        {
            _command.Execute();
        }

        public void UndoMove()
        {
            _command.Undo();
        }
    }
}