using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess
{
    class ChessPosition
    {
        public char posColumn { get; set; }
        public int posLine { get; set; }

        public ChessPosition(char posColumn, int posLine)
        {
            this.posColumn = posColumn;
            this.posLine = posLine;
        }

        public Position toPosition()
        {
            return new Position(8 - posLine, posColumn - 'a');
        }

        public override string ToString()
        {
            return "" + posColumn + posLine;
        }
    }
}
