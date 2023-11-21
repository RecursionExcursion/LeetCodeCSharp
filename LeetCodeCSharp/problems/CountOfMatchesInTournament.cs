using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CountOfMatchesInTournament
    {
        public int NumberOfMatches(int n)
        {

            int numOfMatches = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    numOfMatches += n;
                }
                else
                {
                    int x = n - 1;
                    x /= 2;
                    numOfMatches += x;
                    n = x + 1;
                }
            }
            return numOfMatches;
        }
    }
}
