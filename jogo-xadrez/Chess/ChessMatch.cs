using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess
{
    class ChessMatch
    {
        public Boards board { get; private set; }
        private int turno;
        private Color activePlayer;
        public bool finish { get; private set; }


        public ChessMatch()
        {
            board = new Boards(8, 8);
            turno = 1;
            activePlayer = Color.White;
            putPieces();
            finish = false;
        }

        public void makeMoviment(Position origin, Position destiny)
        {
            Pieces p = board.removePiece(origin);
            p.raiseMoviment();
            Pieces caprturedPieces = board.removePiece(destiny);
            board.putPiece(p,destiny);

        }

        private void putPieces()
        {
            board.putPiece(new Rook(board, Color.White), new ChessPosition('c', 1).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('c', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('d', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('e', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('e', 1).toPosition());
            board.putPiece(new King(board, Color.White), new ChessPosition('d', 1).toPosition());

            board.putPiece(new Rook(board, Color.Black), new ChessPosition('c', 8).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('c', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('d', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('e', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('e', 8).toPosition());
            board.putPiece(new King(board, Color.Black), new ChessPosition('d', 8).toPosition());


        }
    }
}
