using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace jogo_xadrez
{
    class Screen
    {
        public static void PrintBoard(Boards board)
        {
            for(int i = 0;i<board.RowBoard; i++)
            {
                for (int j = 0; j < board.ColumnBoard; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
