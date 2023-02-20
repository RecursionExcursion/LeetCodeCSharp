using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class UniqueNumberOfOccurences
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> intOccurences = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                AddToDict(i);
            }

            return intOccurences.Keys.Count == intOccurences.Values.ToHashSet().Count;

            void AddToDict(int i)
            {
                if (intOccurences.ContainsKey(i))
                {
                    intOccurences[i]++;
                } else
                {
                    intOccurences.Add(i, 1);
                }
            }
        }
    }
}
