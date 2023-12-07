using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CheckIfEveryRowAndColumnContainsAllNumbers
    {
        public bool CheckValid(int[][] matrix)
        {

            int l = matrix.Length;

            for (int i = 0; i < l; i++)
            {
                bool[] n1 = new bool[l];
                bool[] n2 = new bool[l];

                for (int j = 0; j < l; j++)
                {
                    if (n1[matrix[i][j] - 1] == true || n2[matrix[j][i] - 1] == true)
                    {
                        return false;
                    }
                    n1[matrix[i][j] - 1] = true;
                    n2[matrix[j][i] - 1] = true;
                }
            }
            return true;
        }
        //public bool CheckValid(int[][] matrix)
        //{


        //    int l = matrix.Length;
        //    bool[] nums;

        //    foreach (var row in matrix)
        //    {
        //        nums = new bool[l];

        //        foreach (var cell in row)
        //            nums[cell - 1] = true;

        //        foreach (var n in nums)
        //            if (!n)
        //                return false;
        //    }


        //    for (int x = 0; x < l; x++)
        //    {
        //        nums = new bool[l];

        //        for (int y = 0; y < l; y++)
        //            nums[matrix[y][x] - 1] = true;

        //        foreach (var n in nums)
        //            if (!n)
        //                return false;
        //    }
        //    return true;
        //}
    }
}
