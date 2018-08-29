using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    abstract class Player
    {
        Piece ownPiece, queenPiece;
        int numPiecesLeft = 12;
        int numQueens = 0;
        Piece[] pieces;
        public Player(Piece ownPiece, Piece queenPiece, Piece[] pieces)
        {
            this.ownPiece = ownPiece;
            this.queenPiece = queenPiece;
            this.pieces = pieces;
        }

        public abstract Piece[,] DetermineMove();

        public void LosePiece()
        {
            this.numPiecesLeft--;
        }
        public void AddQueen()
        {
            this.numQueens++;
        }
        public void LoseQueen()
        {
            this.numQueens--;
        }
        public Piece GetOwnPiece()
        {
            return this.ownPiece;
        }
        public Piece GetQueenPiece()
        {
            return this.queenPiece;
        }
        public  Piece[] GetPieces()
        {
            return this.pieces;
        }
        
    }
}
