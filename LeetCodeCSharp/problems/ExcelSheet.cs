using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class ExcelSheet
    {
        public int TitleToNumber2(string columnTitle)
        {
            char[] charArray = columnTitle.ToCharArray();
            Array.Reverse(charArray);

            var returnValue = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                var value = charArray[i] - 64;
                value = i == 0 ? value : value * 26 * i;
                returnValue += value;
            }

            return returnValue;
        }
        public int TitleToNumber(string columnTitle)
        {
            return columnTitle.Reverse()
                              .Select((c, index) => (c - 'A' + 1) * (int) Math.Pow(26, index))
                              .Sum();
        }
    }
}


