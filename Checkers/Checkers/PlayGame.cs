using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class PlayGame
    {
        // store a board in:
        // O-O-O-O-
        // -O-O-O-O
        // O-O-O-O-
        // OOOOOOOO
        // OOOOOOOO
        // +O+O+O+O
        // O+O+O+O+
        // +O+O+O+O
        static Piece[,] CreateBoard()
        {
            // counters for each piece type
            int u = 0, d = 0, p = 0;
            // store the pieces in a board
            Piece[,] b = new Piece[8, 8];

            // determine each piece on the board
            //rows
            for(int i = 0; i < 8; i++)
            {
                //columns
                for(int j = 0; j < 8; j++)
                {
                    // if it is an even row
                    if(i % 2 == 0)
                    {
                        // if the row is the first or last 3, and the column is even,
                        // store 'O' as the piece of the board
                        if(j % 2 == 0 &&(i < 3 || i > 4))
                        {
                            b[i, j] = new Piece('O', u);
                            u++;
                        }
                        // if the column is odd, and the row is in the first 3,
                        // store '-' as the piece of the board
                        else if(j % 2 != 0 && i < 3)
                        {
                            b[i, j] = new Piece('-', d);
                            d++;
                        }
                        // if the column is odd, and the row is in the last 3,
                        // store '+' as the piece of the board
                        else if (j % 2 != 0 && i > 4)
                        {
                            b[i, j] = new Piece('+', p);
                            p++;
                        }
                    }

                    else
                    {
                        // if the row is the first or last 3, and the column is odd,
                        // store 'O' as the piece of the board
                        if (j % 2 != 0 && (i < 3 || i > 4))
                        {
                            b[i, j] = new Piece('O', u);
                            u++;
                        }
                        // if the column is even, and the row is in the first 3,
                        // store '-' as the piece of the board
                        else if (j % 2 == 0 && i < 3)
                        {
                            b[i, j] = new Piece('-', d);
                            d++;
                        }
                        // if the column is odd, and the row is in the last 3,
                        // store '+' as the piece of the board
                        else if (j % 2 == 0 && i > 4)
                        {
                            b[i, j] = new Piece('+', p);
                            p++;
                        }
                    }

                    // if the row is the 3rd or 4th row, store 'O' for the entire row.
                    if (i == 3 || i == 4)
                    {
                        b[i, j] = new Piece('O', u);
                        u++;
                    }

                }
            }
            return b;
        }


        static void Main(string[] args)
        {

            Piece[,] board = CreateBoard();
         
            Game newGame = new Game();
            Console.WriteLine("Enter the number of human players: ");
            int numPlayers = int.Parse(Console.ReadLine());
            newGame.Play(board, numPlayers);

            Console.ReadKey();
        }
    }
}
