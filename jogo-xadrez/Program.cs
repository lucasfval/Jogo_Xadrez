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
                ChessMatch match = new ChessMatch();
                while (!match.finish)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.board);
                    Console.WriteLine();
                    Console.WriteLine("Turn: " + match.turn);
                    Console.WriteLine("Waiting play: " + match.activePlayer);
                    Console.WriteLine();
                    Console.Write("Origin: ");                    
                    Position origin = Screen.getChessPosition().toPosition();
                    bool[,] possibles = match.board.piece(origin).possibleMoves();
                    Console.Clear();
                    Screen.PrintBoard(match.board,possibles);
                    Console.WriteLine();
                    Console.Write("Destiny: ");                                       
                    Position destiny = Screen.getChessPosition().toPosition();
                    match.makePlay(origin, destiny);

                }
                

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
