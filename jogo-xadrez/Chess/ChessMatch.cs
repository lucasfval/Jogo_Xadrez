using System;
using System.Collections.Generic;
using System.Text;
using Board;

namespace Chess
{
    class ChessMatch
    {
        public Boards board { get; private set; }
        public int turn { get; private set; }
        public Color activePlayer { get; private set; }
        public bool finish { get; private set; }


        public ChessMatch()
        {
            board = new Boards(8, 8);
            turn = 1;
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

        public void makePlay(Position origin, Position destiny)
        {
            makeMoviment(origin, destiny);
            turn++;
            changePlayer();
        }

        public void validateOriginPosition(Position pos)
        {
            if (board.piece(pos) == null)
            {
                throw new BoardException("No piece in origin position.");
            }
            if(activePlayer != board.piece(pos).Color)
            {
                throw new BoardException("Wrong color piece.");
            }
            if (!board.piece(pos).existPossibleMoves())
            {
                throw new BoardException("No possible moves for this piece");
            }
        }


        public void validateDestinyPosition(Position origin, Position destiny)
        {
            if(!board.piece(origin).canMoveTo(destiny))
            {
                throw new BoardException("Invalid destiny position.");
            }
        }

        private void changePlayer()
        {
            if(activePlayer == Color.White)
            {
                activePlayer = Color.Black;
            }
            else
            {
                activePlayer = Color.White;
            }
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
