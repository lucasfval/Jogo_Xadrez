using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess
{
    class King : Pieces
    {
        public King(Boards boards, Color color) : base(boards, color)
        {

        }
        public override string ToString()
        {
            return "K";
        }
    }
}
