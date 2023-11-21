using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {

            int max = -1;

            foreach (var acc in accounts)
            {
                int sum = 0;
                foreach (var i in acc)
                {
                    sum += i;
                }
                max = Math.Max(sum, max);
            }

            return max;
        }

        public int MaximumWealth2(int[][] accounts) => accounts.Select(acc => acc.Sum()).Max();

    }
}

