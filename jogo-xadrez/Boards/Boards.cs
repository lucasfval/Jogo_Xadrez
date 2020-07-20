using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Boards
    {
        public int RowBoard { get; set; }
        public int ColumnBoard { get; set; }
        private Pieces[,] PiecesBoard { get; set; }

        public Boards(int rowBoard, int columnBoard)
        {
            RowBoard = rowBoard;
            ColumnBoard = columnBoard;
            PiecesBoard = new Pieces[RowBoard, ColumnBoard];
        }

        public Pieces piece(int RowBoard, int ColumnBoard)
        {
            return PiecesBoard[RowBoard, ColumnBoard];
        }

        public Pieces piece(Position pos) //return a piece position
        {
            return PiecesBoard[pos.Row, pos.Column];
        }

        public bool existPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void putPiece(Pieces p, Position pos)//put the piece in the board
        {
            if (existPiece(pos))
            {
                throw new BoardException("Theres a piece in this position");
            }
            PiecesBoard[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

        public Pieces removePiece(Position pos)
        {
            if (piece(pos) == null)
            {
                return null;
            }
            Pieces aux = piece(pos);
            aux.Position = null;
            PiecesBoard[pos.Row, pos.Column] = null;
            return aux;
        }

        public bool positionValue(Position pos) //Test if position exists in the board.
        {
            if (pos.Row < 0 || pos.Row >= RowBoard || pos.Column < 0 || pos.Column >= ColumnBoard)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void validatePosition(Position pos)
        {
            if (!positionValue(pos))
            {
                throw new BoardException("Invalid Position");
            }
        }

    }
}
