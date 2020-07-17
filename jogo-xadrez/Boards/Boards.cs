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

        public Pieces piece(int RowBoard,int ColumnBoard)
        {
            return PiecesBoard[RowBoard, ColumnBoard];
        }

        public void putPiece(Pieces p, Position pos)
        {
            PiecesBoard[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

    }
}
