using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            List<List<int>> sequences = new();


            GetSequence(0, null);

            return sequences.Select(seq => seq.Count).Max();


            void GetSequence(int index, List<int>? seq)
            {
                seq ??= new() { nums[index] };
                sequences.Add(seq);
                for (int i = index; i < nums.Length - 1; i++)
                {
                    if (seq[^1] < nums[i + 1])
                    {
                        List<int> newSeq = new List<int>(seq);
                        seq.Add(nums[i + 1]);
                        GetSequence(i + 1, newSeq);
                    }
                }
            }
        }
    }
}
