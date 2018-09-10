using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        static bool gameOver = false;
        static Player[] players;
        static Piece[,] Board;

        static void DisplayBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Board[i, j].GetPieceType() + " ");
                }
                Console.WriteLine();

            }
        }


        //debuggng function to check if correct information is stored.
        private void DisplayPlayerInfo()
        {

            //player one

            //ownpiece
            Console.WriteLine("Player one piece is: " + players[0].GetOwnPiece().GetPieceType());

            //queenpiece
            Console.WriteLine("Player one queen is: " + players[0].GetQueenPiece().GetPieceType());

            //pieces[]: piecetype, pID, row, col
            Piece[] a = players[0].GetPieces();
            for (int i = 0; i < 12; i++)
            {

                char p = a[i].GetPieceType();
                int id = a[i].GetpID();
                int r = a[i].GetRow();
                int c =  a[i].GetColumn();
                Console.WriteLine("Player piece " + i + " is: " + p);
                Console.WriteLine("Player pieceID " + i + " is: " + id);
                Console.WriteLine("Player piece row " + i + " is: " + r);
                Console.WriteLine("Player piece column " + i + " is: " + c);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //player Two

            //ownpiece
            Console.WriteLine("Player Two piece is: " + players[1].GetOwnPiece().GetPieceType());

            //queenpiece
            Console.WriteLine("Player Two queen is: " + players[1].GetQueenPiece().GetPieceType());

            //pieces[]: piecetype, pID, row, col
            Piece[] b = players[1].GetPieces();
            for (int i = 0; i < 12; i++)
            {

                char p = b[i].GetPieceType();
                int id = b[i].GetpID();
                int r = b[i].GetRow();
                int c = b[i].GetColumn();
                Console.WriteLine("Player piece " + i + " is: " + p);
                Console.WriteLine("Player pieceID " + i + " is: " + id);
                Console.WriteLine("Player piece row " + i + " is: " + r);
                Console.WriteLine("Player piece column " + i + " is: " + c);
                Console.WriteLine();
            }



        }

        
        public void Play(Piece[,] b, int numPlayers, Piece[] one, Piece[] two)
        {

            Board = b;
            //initializing varables, used only to initialize players
            Piece plus = new Piece('+');
            Piece plusQueen = new Piece('$');
            Piece dash = new Piece('-');
            Piece dashQueen = new Piece('=');
            Console.WriteLine("Here is the board that will be used by " + numPlayers + " player(s): ");
            if (numPlayers == 2)
            {
                players = new Player[2] { new HumanPlayer(plus, plusQueen, one),
                                           new HumanPlayer(dash, dashQueen, two)};
            }
            else if(numPlayers == 1)
            {
                players = new Player[2] { new HumanPlayer(plus, plusQueen, one),
                                           new ComputerPlayer(dash, dashQueen, two)};
            }
            else
            {
                players = new Player[2] { new ComputerPlayer(plus, plusQueen, one),
                                           new ComputerPlayer(dash, dashQueen, two)};
            }


            DisplayBoard();
            Console.WriteLine("Plus goes first. Make your move. Pieces are numbered 0-11 from top left " +
                "to bottom right of your starting side");
            //  Board = players[0].DetermineMove(Board);
            //  DisplayBoard();

            int i = 0;
            while (!gameOver)
            {
                Board = players[i].DetermineMove(Board);
                DisplayBoard();

                if(i == 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                Console.WriteLine();
            }

            // DisplayPlayerInfo();
        }

    }
}
