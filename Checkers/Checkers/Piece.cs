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
        int pID, row, column;
        bool isQueen = false;
        bool stillInPlay = true;
        public Piece(char pieceType, int pID, int row, int column)
        {
            this.pieceType = pieceType;
            this.pID = pID;
            this.row = row;
            this.column = column;
        }
        public Piece(char pieceType)
        {
            this.pieceType = pieceType;
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
        public void SetRow(int r)
        {
            this.row = r;
        }
        public void SetColumn(int c)
        {
            this.column = c;
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
        public int GetRow()
        {
            return this.row;
        }
        public int GetColumn()
        {
            return this.column;
        }

    }


}
