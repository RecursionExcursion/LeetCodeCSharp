using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class KthLargestElementInArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums[k-1];
        }
    }
}
