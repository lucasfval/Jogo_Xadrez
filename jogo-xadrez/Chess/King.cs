using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess
{
    class King : Pieces
    {
        public King(Boards board, Color color) : base(board, color)
        {

        }
        public override string ToString()
        {
            return "K";
        }

        private bool canMove(Position pos)
        {
            Pieces p = Board.piece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[Board.RowBoard, Board.ColumnBoard];
            Position pos = new Position(0, 0);
            //north
            pos.defineValue(Position.Row - 1, Position.Column);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //northeast
            pos.defineValue(Position.Row - 1, Position.Column + 1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //east
            pos.defineValue(Position.Row , Position.Column + 1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //southeast
            pos.defineValue(Position.Row+1, Position.Column + 1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //south
            pos.defineValue(Position.Row + 1, Position.Column);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //southwest
            pos.defineValue(Position.Row + 1, Position.Column - 1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //west
            pos.defineValue(Position.Row, Position.Column - 1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            //northweast
            pos.defineValue(Position.Row -1, Position.Column -1);
            if (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }
            return mat;


        }
    }
}
