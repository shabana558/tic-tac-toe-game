using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_game
{
    internal class tic_tac_toe_game
    {
        private static bool board;

        public static char[] Initializing()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';

            }
            return board;
        }

        public static char Choosing()
        {
            Console.WriteLine("choose option:");
            string letter = Console.ReadLine();
            return char.ToUpper(letter[0]);
        }
        public static void Display()
        {
            Console.WriteLine(board);
        }

    }
}


