using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CountHillsAndValleysInAnArray
    {
        public int CountHillValley(int[] nums)
        {

            int ans = 0;


            for (int i = 1; i < nums.Length - 1; i++)
            {

                int left = nums[i - 1];
                int mid = nums[i];
                int right = nums[i + 1];

                int j = i + 2;
                while (j < nums.Length && right == mid)
                {
                    right = nums[j++];
                    i++;
                }

                int leftEle = left - mid;
                int rightEle = right - mid;

                if (leftEle > 0 && rightEle > 0 ||
                    leftEle < 0 && rightEle < 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
