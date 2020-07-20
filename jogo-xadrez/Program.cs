using System;
using Board;
using Chess;


namespace jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Boards board = new Boards(8, 8);
                board.putPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.putPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.putPiece(new King(board, Color.Black), new Position(0, 2));
                board.putPiece(new King(board, Color.White), new Position(3,5));
                Screen.PrintBoard(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
