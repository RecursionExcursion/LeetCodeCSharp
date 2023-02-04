using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class FindWinnerOnATicTacToeGame
    {

        public static string Tictactoe(int[][] moves)
        {

            string a = "A";
            string b = "B";
            string draw = "Draw";
            string pending = "Pending";
            string[] strings = new string[9];
            bool isAsTurn = true;

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int x = moves[i][0];
                int y = moves[i][1];

                string s = isAsTurn ? a : b;
                strings[(x * 3) + y] = s;


                isAsTurn = !isAsTurn;
            }
            for (int i = 0; i < 3; i++)
            {
                /**
                * Horizontal 
                */

                int h = i * 3;

                if (strings[h] != null && strings[h] == strings[h + 1] &&
                    strings[h + 1] == strings[h + 2])
                {
                    return strings[h];
                }

                /**
                 * Vertical 
                 */
                if (strings[i] != null && strings[i] == strings[i + 3] &&
                    strings[i + 3] == strings[i + 6])
                {
                    return strings[i];
                }
            }


            /**
             * Diagnols
             */
            if (strings[0] != null && strings[0] == strings[4] && strings[4] == strings[8])
            {
                return strings[4];
            }
            if (strings[2] != null && strings[2] == strings[4] && strings[4] == strings[6])
            {
                return strings[4];
            }

            foreach (string s in strings)
            {
                if (s == null)
                {
                    return pending;
                }
            }
            return draw;
        }
        
    }
}
