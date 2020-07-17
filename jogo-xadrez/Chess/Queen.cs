using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess

{
    class Queen : Pieces
    {
        public Queen(Boards boards, Color color) : base(boards, color)
        {

        }
        public override string ToString()
        {
            return "Q";
        }
    }
}
