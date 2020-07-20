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
            for (int i = 0; i < board.RowBoard; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.ColumnBoard; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printPiece(board.piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printPiece(Pieces piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
        }
    }
}
