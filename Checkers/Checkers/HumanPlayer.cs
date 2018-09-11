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

        //TO-DO:    
        //          3. allow jumping

        public override Piece[,] DetermineMove(Piece[,] board)
        {
            bool isInvalidMove = true;
            bool isInvalidPiece = true;
            int originalRow = 0;
            int originalColumn = 0;
            int newRow = 0;
            int newCol = 0;
            int id = 0;
            Piece pieceToMove = new Piece('O');
            while (isInvalidMove)
            {


                //get which piece from user
                while (isInvalidPiece)
                {
                    Console.WriteLine("Move which piece? (num)");
                    id = int.Parse(Console.ReadLine());



                    //store the piece thats being moved
                    pieceToMove = this.GetPieces()[id];
                    if (MoveChecker.CheckPieceStillPlayable(pieceToMove))
                    {
                        isInvalidPiece = false;
                    }
                }

                //keep the original row and column and create variables for new row and column
                originalRow = pieceToMove.GetRow();
                originalColumn = pieceToMove.GetColumn();

                //get direction from user
                Console.WriteLine("Move left or right and up or down? l/r for pawns, or ul/dl/ur/dr for queens: ");
                String move = Console.ReadLine();

                //if queen, move queen:
                if (pieceToMove.GetIsQueen())
                {
                    switch (move)
                    {
                        case "ul":
                            newRow = originalRow - 1;
                            newCol = originalColumn - 1;
                            break;
                        case "dl":
                            newRow = originalRow + 1;
                            newCol = originalColumn - 1;
                            break;
                        case "ur":
                            newRow = originalRow - 1;
                            newCol = originalColumn + 1;
                            break;
                        case "dr":
                            newRow = originalRow + 1;
                            newCol = originalColumn + 1;
                            break;
                        default:
                            newRow = 9;
                            newCol = 9;
                            break;
                    }
                }
                //else do below:
                else
                {
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

                }





                if (MoveChecker.CheckBoardBounds(newRow, newCol, board))
                {
                    char checkMovePiece = MoveChecker.CheckPieceAtMoveToForSamePieceType(newRow, newCol, board, this.GetPieces()[id]);

                    switch (checkMovePiece)
                    {
                        case 'o':
                            isInvalidMove = false;
                            break;
                        case 's':
                            Console.WriteLine("Invalid move. Choose new move!");
                            isInvalidPiece = true;
                            break;
                        case 'd':
                            //check for jumping in direction
                            //int i is 1
                            //if jumpable
                                //while jumpable
                                    //if i iis 1
                                        //jump in move direction
                                        //i++
                                    //else
                                        //create array of jumping dirs
                                        //if array size is 0
                                            //jumpable is false
                                        //else
                                            //ask jump direction
                                                //if no, jumpable is false
                                                //else move 
                                    //i++
                                    //display board after each jump
                            //else
                                //isInvalidPiece = true;
                            isInvalidMove = false;
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Invalid move. Choose new move!");
                    isInvalidPiece = true;
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
