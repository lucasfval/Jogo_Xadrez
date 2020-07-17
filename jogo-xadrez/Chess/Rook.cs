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
        public override string ToString()
        {
            return "R";
        }
    }
}
