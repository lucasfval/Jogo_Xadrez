using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    abstract class Pieces
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MoveQuantity { get; protected set; }
        public Boards Board { get; protected set; }

        public Pieces(Boards board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            MoveQuantity = 0;
        }

        public void raiseMoviment()
        {
            MoveQuantity++;
        }

        public bool existPossibleMoves()
        {
            bool[,] mat = possibleMoves();
            for (int i = 0; i < Board.RowBoard; i++)
            {
                for (int j = 0; j < Board.ColumnBoard; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    } 
                }
            }
            return false;
        }

        public bool canMoveTo(Position pos)
        {
            return possibleMoves()[pos.Row, pos.Column];
        }

        public abstract bool[,] possibleMoves();
    }
}
