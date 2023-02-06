using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    internal class DivideArrayIntoEqualPairs
    {
        public static bool DivideArray(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (int i in nums)
            {
                if (result.Contains(i)) result.Remove(i);
                else result.Add(i);

            }
            return result.Count == 0;
        }

        /*
        public static bool DivideArray(int[] nums)
        {
            Dictionary<int, int> occurs = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (occurs.ContainsKey(i)) occurs[i]++;
                else occurs[i] = 1;

            }
            foreach (int key in occurs.Keys)
            {
                if (!(occurs[key] % 2 == 0)) return false;
            }
            return true;
        }
        */
    }
}
