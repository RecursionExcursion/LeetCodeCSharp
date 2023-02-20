using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class SortColors
    {
        public static void SortColorsInts(int[] nums)
        {

            for (int i = 0, frontIndex = 0, endIndex = nums.Length - 1;
                i <= endIndex;
                i++)
            {
                int current = nums[i];

                if (current == 0)
                {
                    nums[i] = nums[frontIndex];
                    nums[frontIndex++] = current;
                } else if (current == 2)
                {
                    nums[i--] = nums[endIndex];
                    nums[endIndex--] = current;
                }
            }
        }

        /*
        public static void SortColorsInts(int[] nums)
        {
            Dictionary<int, int> intOccurs = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 0 },
                { 2, 0 }
            };

            foreach (int n in nums)
            {
                intOccurs[n]++;
            }

            int index = 0;

            foreach (int key in intOccurs.Keys)
            {
                while (intOccurs[key] > 0)
                {
                    nums[index++] = key;
                    intOccurs[key]--;
                }
            }
        }
        */
    }
}

