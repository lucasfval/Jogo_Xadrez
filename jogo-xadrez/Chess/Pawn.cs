using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess

{
    class Pawn : Pieces
    {
        public Pawn(Boards boards, Color color) : base(boards, color)
        {

        }
        public override string ToString()
        {
            return "p";
        }
    }
}
