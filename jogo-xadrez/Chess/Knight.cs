using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess

{
    class Knight : Pieces
    {
        public Knight(Boards boards, Color color) : base(boards, color)
        {

        }
        public override string ToString()
        {
            return "N";
        }
    }
}
