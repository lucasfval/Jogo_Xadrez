using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess

{
    class Rook : Pieces
    {
        public Rook(Boards boards, Color color) : base(boards, color)
        {

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
            while (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.piece(pos) != null && Board.piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row - 1;
            }
            //south
            pos.defineValue(Position.Row + 1, Position.Column);
            while (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.piece(pos) != null && Board.piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row + 1;
            }
            //east
            pos.defineValue(Position.Row, Position.Column + 1);
            while (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.piece(pos) != null && Board.piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column + 1;
            }
            //west
            pos.defineValue(Position.Row, Position.Column - 1);
            while (Board.positionValue(pos) && canMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.piece(pos) != null && Board.piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column = pos.Column - 1;
            }
            return mat;
        }


        public override string ToString()
        {
            return "R";
        }
    }
}
