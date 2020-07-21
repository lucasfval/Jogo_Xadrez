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
        private HashSet<Pieces> pieces;
        private HashSet<Pieces> captured;



        public ChessMatch()
        {
            board = new Boards(8, 8);
            turn = 1;
            activePlayer = Color.White;
            finish = false;
            pieces = new HashSet<Pieces>();
            captured = new HashSet<Pieces>();
            putPieces();

        }

        public void makeMoviment(Position origin, Position destiny)
        {
            Pieces p = board.removePiece(origin);
            p.raiseMoviment();
            Pieces capturedPieces = board.removePiece(destiny);
            board.putPiece(p, destiny);
            if(capturedPieces != null)
            {
                captured.Add(capturedPieces);
            }

        }

        public void makePlay(Position origin, Position destiny)
        {
            makeMoviment(origin, destiny);
            turn++;
            changePlayer();
        }

        public HashSet<Pieces> piecesCaptured(Color color)
        {
            HashSet<Pieces> aux = new HashSet<Pieces>();
            foreach(Pieces x in captured)
            {
                if(x.Color == color)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Pieces> inGamePieces(Color color)
        {
            HashSet<Pieces> aux = new HashSet<Pieces>();
            foreach (Pieces x in pieces)
            {
                if (x.Color == color)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(piecesCaptured(color));
        }

        public void validateOriginPosition(Position pos)
        {
            if (board.piece(pos) == null)
            {
                throw new BoardException("No piece in origin position.");
            }
            if (activePlayer != board.piece(pos).Color)
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
            if (!board.piece(origin).canMoveTo(destiny))
            {
                throw new BoardException("Invalid destiny position.");
            }
        }

        private void changePlayer()
        {
            if (activePlayer == Color.White)
            {
                activePlayer = Color.Black;
            }
            else
            {
                activePlayer = Color.White;
            }
        }

        public void putNewPiece(char column, int row, Pieces piece)
        {
            board.putPiece(piece, new ChessPosition(column, row).toPosition());
            pieces.Add(piece);

        }

        private void putPieces()
        {
            putNewPiece('c', 1, new Rook(board, Color.White));
            putNewPiece('c', 2, new Rook(board, Color.White));
            putNewPiece('d', 2, new Rook(board, Color.White));
            putNewPiece('e', 2, new Rook(board, Color.White));
            putNewPiece('e', 1, new Rook(board, Color.White));
            putNewPiece('d', 1, new King(board, Color.White));


            putNewPiece('c', 7, new Rook(board, Color.Black));
            putNewPiece('c', 8, new Rook(board, Color.Black));
            putNewPiece('d', 7, new Rook(board, Color.Black));
            putNewPiece('e', 7, new Rook(board, Color.Black));
            putNewPiece('e', 8, new Rook(board, Color.Black));
            putNewPiece('d', 8, new King(board, Color.Black));
        }
    }
}
