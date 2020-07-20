using System;
using System.Collections.Generic;
using System.Text;
using Board;
using Chess;

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
                    printPiece(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintBoard(Boards board, bool[,] possibles)
        {
            ConsoleColor originalBack = Console.BackgroundColor;
            ConsoleColor newBack = ConsoleColor.DarkGray;
            for (int i = 0; i < board.RowBoard; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.ColumnBoard; j++)
                {
                    if (possibles[i, j])
                    {
                        Console.BackgroundColor = newBack;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBack;
                    }
                    printPiece(board.piece(i, j));
                    Console.BackgroundColor = originalBack;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalBack;

        }

        public static ChessPosition getChessPosition()
        {
            string s = Console.ReadLine().ToLower();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }




        public static void printPiece(Pieces piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }
        }
    }
}
