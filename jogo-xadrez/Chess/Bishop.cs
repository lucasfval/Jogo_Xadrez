using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess

{
    class Bishop : Pieces
    {
        public Bishop(Boards boards, Color color) : base(boards, color)
        {

        }
        public override string ToString()
        {
            return "B";
        }
    }
}
