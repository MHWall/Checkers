﻿using System;
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
            Random rnd = new Random();
            Piece pieceToMove;

            //1 is left, 2 is right
            int move = rnd.Next(1, 2);

            //id of piece to move
            int id = rnd.Next(0, 11);
            pieceToMove = this.GetPieces()[id];

            //store original row and column
            int originalRow = pieceToMove.GetRow();
            int originalColumn = pieceToMove.GetColumn();
            int newRow, newCol;


            //check if piece to move is plus.
            if (pieceToMove.GetPieceType() == '+')
            {
                //if user chose to move as a plus to the left, 
                if (move == 1 )
                {
                    newRow = originalRow - 1;
                    newCol = originalColumn - 1;

                }

                //if user chose to move as a plus to the right, 
                else
                {
                    newRow = originalRow - 1;
                    newCol = originalColumn + 1;
                }
            }
            else
            {
                //if user chose to move as a minus to the left, 
                if (move == 1)
                {
                    newRow = originalRow + 1;
                    newCol = originalColumn - 1;

                }
                //if user chose to move as a minus to the right, 
                else
                {
                    newRow = originalRow + 1;
                    newCol = originalColumn + 1;
                }
            }

            //store original piece from board
            Piece original = board[originalRow, originalColumn];

            //since the original piece in the original row and column is stored and is moving,
            //this space is now empty, so it will become an empty piece, or an 'O'
            board[originalRow, originalColumn] = board[newRow, newCol];
            board[originalRow, originalColumn].SetRow(originalRow);
            board[originalRow, originalColumn].SetColumn(originalColumn);

            //place the original piece in the new row and column that the piece is to be put on.
            board[newRow, newCol] = original;
            board[newRow, newCol].SetRow(newRow);
            board[newRow, newCol].SetColumn(newCol);

            //update the Pieces the player owns
            this.GetPieces()[id] = board[newRow, newCol];



            return board;
        }
    }
}
