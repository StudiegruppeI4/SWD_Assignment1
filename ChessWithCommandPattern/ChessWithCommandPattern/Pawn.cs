using System;

namespace ChessWithCommandPattern
{
    public class Pawn : Piece
    {
        private int _moves = 0;

        public Pawn(Position position)
        {
            Position = position;
        }

        public void Move()
        {
            Console.Write($"Moving Pawn from ({Position.X}, {Position.Y})");
            Position.Y++;
            Console.WriteLine($" to ({Position.X}, {Position.Y})");
            _moves++;
        }

        public void Undo()
        {
            if (_moves > 0)
            {
                Console.Write($"Moving Pawn back from ({Position.X}, {Position.Y})");
                Position.Y--;
                Console.WriteLine($" to ({Position.X}, {Position.Y})");
                _moves--;
            }
            else
            {
                Console.WriteLine("You haven't made a move yet!");
            }
        }

        private Position Position { get; set; }
    }
}