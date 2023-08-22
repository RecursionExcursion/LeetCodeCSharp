using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class SecondHighestSolution
    {
        public int SecondHighest(string s)
        {
            return s.Where(c => Regex.IsMatch(c.ToString(), "\\d"))
                    .Distinct()
                    .Select(c => c - '0')
                    .OrderByDescending(s => s)
                    .Skip(1)
                    .FirstOrDefault(-1);
        }


        public int SecondHighest3(string s)
        {
            int max = -1;
            int max2 = -1;

            foreach (var c in s)
            {
                if (c >= 48 && c <= 57)
                {
                    if (c > max2)
                    {
                        if (c > max)
                        {
                            max2 = max;
                            max = c;
                        }
                        else if (c != max)
                        {
                            max2 = c;
                        }
                    }
                }
            }
            return max2 == -1 ? -1 : (char) max2 - '0';
        }
        public int SecondHighest2(string s)
        {
            int max = -1;
            int max2 = -1;

            foreach (var c in s)
            {
                if (c >= 48 && c <= 57)
                {
                    if (c > max2)
                    {
                        if (c > max)
                        {
                            max2 = max;
                            max = c;
                        }
                        else if (c != max)
                        {
                            max2 = c;
                        }
                    }
                }
            }
            return max2 == -1 ? -1 : (char) max2 - '0';
        }
    }
}