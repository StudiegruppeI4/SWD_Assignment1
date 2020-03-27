using System;

namespace ChessWithCommandPattern
{
    public class Knight : Piece
    {
        private int _moves = 0;

        public Knight(Position position)
        {
            Position = position;
        }

        public void Move()
        {
            Console.Write($"Moving Knight from ({Position.X}, {Position.Y})");
            Position.Y += 2;
            Position.X--;
            Console.WriteLine($" to ({Position.X}, {Position.Y})");
        }

        public void Undo()
        {
            if (_moves > 0)
            {
                Console.Write($"Moving Knight back from ({Position.X}, {Position.Y})");
                Position.Y -= 2;
                Position.X++;
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