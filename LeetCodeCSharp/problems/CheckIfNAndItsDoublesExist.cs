using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CheckIfNAndItsDoublesExist
    {
        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length;i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j) continue;
                    if (arr[i] == arr[j] * 2) return true;
                }
            }
            return false;
        }
    }
}
