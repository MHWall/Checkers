using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(Piece ownPiece, Piece queenPiece, Piece[] pieces)
            : base(ownPiece, queenPiece, pieces)
        {

        }

        public override Piece[,] DetermineMove(Piece[,] board)
        {
            return new Piece[8,8];
        }
    }
}
