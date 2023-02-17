using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class FindTheDuplicateNumber
    {

        public static int FindDuplicate2(int[] nums)
        {
            return (nums.Sum() - Enumerable.Range(1, nums.Length - 1).Sum()) / (nums.Length - nums.Max());
        }
       
        public static int FindDuplicateNotConstantSpace(int[] nums)
        {
            HashSet<int> intSet = new();
            foreach (int i in nums)
            {
                if (!intSet.Add(i))
                {
                    return i;
                }
            }
            return -1;
        }


        public static int FindDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return nums[i];
                    }
                }
            }
            return -1;
        }
    }
}
