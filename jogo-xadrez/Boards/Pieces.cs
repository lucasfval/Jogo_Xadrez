﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Pieces
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MoveQuantity { get;protected  set; }
        public Boards Board { get;protected set; }

        public Pieces(Position position, Boards board, Color color)
        {
            Position = position;
            Board = board;
            Color = color;
            MoveQuantity = 0;
        }







    }
}