using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Piece
    {
        char pieceType;
        int pID;
        bool isQueen = false;
        bool stillInPlay = true;
        public Piece(char pieceType, int pID)
        {
            this.pieceType = pieceType;
            this.pID = pID;
        }

        public void SetIsQueen(bool q)
        {
            this.isQueen = q;
        }

        public void SetStillInPlay(bool p)
        {
            this.stillInPlay = p;
        }

        public void SetpID(int pID)
        {
            this.pID = pID;
        }

        public char GetPieceType()
        {
            return this.pieceType;
        }

        public bool GetIsQueen()
        {
            return this.isQueen;
        }

        public bool GetStillInPlay()
        {
            return this.stillInPlay;
        }

        public int GetpID()
        {
            return this.pID;
        }
    }


}
