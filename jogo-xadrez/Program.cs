﻿using System;
using Board;
using Chess;


namespace jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosition());
        }
    }
}
