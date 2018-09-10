using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class MoveChecker
    {
        //check to make sure a move is in bounds
        public static bool CheckBoardBounds(int x, int y, Piece[,] board)
        {
            int xSize = board.GetLength(0);
            int ySize = board.GetLength(1);
            if(x < 0 ||  y < 0)
            {
                return false;
            }
            else if (x >= xSize || y >= ySize)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool CheckPieceAtMoveToForSamePieceType(int x, int y, Piece[,] board, Piece playerBoardPiece)
        {
            char boardPiece = board[x, y].GetPieceType();
            char playerPiece = playerBoardPiece.GetPieceType();
            if (boardPiece == playerPiece)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPieceStillPlayable(Piece playerBoardPiece)
        {
            if (playerBoardPiece.GetStillInPlay())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


      
    }
}
