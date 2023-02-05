using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class ShuffleString
    {
        public static string RestoreString(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder();

            int i = 0, c = 0;
            while (c < indices.Length)
            {
                if (indices[i] == c)
                {
                    c++;
                    sb.Append(s.ElementAt(i));
                    i = 0;
                    continue;
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
