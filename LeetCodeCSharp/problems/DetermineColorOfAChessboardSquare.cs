using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class DetermineColorOfAChessboardSquare
    {
        public static bool SquareIsWhite(string coordinates)
        {

            byte[] asciBytes = Encoding.ASCII.GetBytes(coordinates);
            return asciBytes[0] % 2 != 0 ? asciBytes[1] % 2 == 0 : asciBytes[1] % 2 != 0;
        }
    }
}
