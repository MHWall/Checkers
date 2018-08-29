using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Piece ownPiece, Piece queenPiece, Piece[] pieces)
            :base(ownPiece, queenPiece, pieces)
        {

        }
        public override Piece[,] DetermineMove()
        {
            return new Piece[8, 8];
        }

    }
}
