using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        static Piece[,] Board;
        static void DisplayBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Board[i, j].GetPieceType());
                }
                Console.WriteLine();

            }
        }

        public void Play(Piece[,] b, int numPlayers)
        {

            Board = b;
            Console.WriteLine("Here is the board that will be used by " + numPlayers + " player(s): ");
            DisplayBoard();
        }

    }
}
