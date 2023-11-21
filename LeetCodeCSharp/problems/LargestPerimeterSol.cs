using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class LargestPerimeterSol
    {

        /*
         * The rule of the sides of a triangle is that the sum of the lengths
         * of any two sides of a triangle is always greater than the length
         * of the third side. 
         */
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            for (int i = nums.Length - 1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                    return nums[i] + nums[i - 1] + nums[i - 2];
            }
            return 0;
        }
    }
}