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

        //TO-DO:    1. check if valid move,
        //          2. queen functionality
        //          3. allow jumping
        public override Piece[,] DetermineMove(Piece[,] board)
        {
            //get which piece from user
            Console.WriteLine("Move which piece? (num)");
            int id = int.Parse(Console.ReadLine());

            //store the piece thats being moved
            Piece pieceToMove = this.GetPieces()[id];

            //keep the original row and column and create variables for new row and column
            int originalRow = pieceToMove.GetRow();
            int originalColumn = pieceToMove.GetColumn();
            int newRow, newCol;

            //get direction from user
            Console.WriteLine("Move left or right? l/r: ");
            String move = Console.ReadLine();

            //check if piece to move is plus.
            if(pieceToMove.GetPieceType() == '+')
            {
                //if user chose to move as a plus to the left, 
                if (move == "l")
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
                if (move == "l")
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
