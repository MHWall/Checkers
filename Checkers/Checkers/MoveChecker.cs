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


        public static char CheckPieceAtMoveToForSamePieceType(int x, int y, Piece[,] board, Piece playerBoardPiece)
        {
            char boardPiece = board[x, y].GetPieceType();
            char playerPiece = playerBoardPiece.GetPieceType();
            /*if (boardPiece == playerPiece)
            {
                return 's';
            }
            else if(boardPiece == 'O')
            {
                return 'o';
            }
            else
            {
                return 'd';
            }*/
            if((playerPiece == '+' || playerPiece == '#') && (boardPiece == '+' || boardPiece == '#'))
            {
                return 's';
            }
            else if ((playerPiece == '-' || playerPiece == '=') && (boardPiece == '-' || boardPiece == '='))
            {
                return 's';
            }
            else if(boardPiece == 'O')
            {
                return 'o';
            }
            else
            {
                return 'd';
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
