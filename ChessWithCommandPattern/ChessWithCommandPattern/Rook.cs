using System;

namespace ChessWithCommandPattern
{
    public class Rook : Piece
    {
        private int _moves = 0;

        public Rook(Position position)
        {
            Position = position;
        }

        public void Move()
        {
            Console.Write($"Moving Rook from ({Position.X}, {Position.Y})");
            Position.Y += 4;
            Console.WriteLine($" to ({Position.X}, {Position.Y})");
            _moves++;
        }

        public void Undo()
        {
            if (_moves > 0)
            {
                Console.Write($"Moving Rook back from ({Position.X}, {Position.Y})");
                Position.Y -= 4;
                Console.WriteLine($" to ({Position.X}, {Position.Y})");
                _moves--;
            }
            else
            {
                Console.WriteLine("You haven't made a move yet!");
            }
        }

        public Position Position { get; set; }
    }
}