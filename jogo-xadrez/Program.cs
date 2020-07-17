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
                board.putPiece(new Rook(board, Color.Black), new Position(0, 0)); //Put a Rook on 0,0
                board.putPiece(new Rook(board, Color.Black), new Position(1, 3)); //Put a Rook on 1,3
                board.putPiece(new King(board, Color.Black), new Position(1, 9)); //Put a King on 2,4
                board.putPiece(new King(board, Color.Black), new Position(2, 9)); //Put a King on 2,4
                Screen.PrintBoard(board);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
