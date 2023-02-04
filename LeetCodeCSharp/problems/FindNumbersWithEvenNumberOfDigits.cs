using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class FindNumbersWithEvenNumberOfDigits
    {
        public static int findNumbers(int[] nums)
        {
            int count = 0;
            foreach (int n in nums)
            {            
                if (n.ToString().Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
