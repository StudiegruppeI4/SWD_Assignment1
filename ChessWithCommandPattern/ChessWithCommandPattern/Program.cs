using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWithCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Rook rook1 = new Rook(new Position() {X = 0, Y = 0});
            Rook rook2 = new Rook(new Position() { X = 7, Y = 0 });
            Knight knight1 = new Knight(new Position() { X = 1, Y = 0 });
            Pawn pawn1 = new Pawn(new Position() { X = 0, Y = 1 });

            MoveRookCommand moveRook = new MoveRookCommand(rook1);
            player.SetCommand(moveRook);
            player.MakeMove();
            player.MakeMove();

            MoveKnightCommand moveKnight = new MoveKnightCommand(knight1);
            player.SetCommand(moveKnight);
            player.MakeMove();

            moveRook = new MoveRookCommand(rook2);
            player.SetCommand(moveRook);
            player.MakeMove();

            moveRook = new MoveRookCommand(rook1);
            player.SetCommand(moveRook);
            player.MakeMove();
            player.UndoMove();
        }
    }
}
