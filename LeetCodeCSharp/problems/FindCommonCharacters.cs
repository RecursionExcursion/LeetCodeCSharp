using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] words)
        {
            List<Dictionary<string, int>> dicList = new List<Dictionary<string, int>>();
            foreach (string word in words)
            {
                Dictionary<string, int> map = new Dictionary<string, int>();
                void addToMap(string s)
                {
                    if (map.ContainsKey(s)) map[s]++;
                    else map.Add(s, 1);
                }
                string charToString(char c) => c.ToString();
                char[] chars = word.ToCharArray();
                chars.ToList().ForEach(c => addToMap(charToString(c)));
                dicList.Add(map);
            }
            var lettersMap = dicList[0];
            for (int i = 1; i < dicList.Count(); i++)
            {
                var otherWordMap = dicList[i];
                foreach (string key in lettersMap.Keys)
                {
                    if (otherWordMap.ContainsKey(key))
                    {
                        lettersMap[key] = lettersMap[key] == otherWordMap[key] ? lettersMap[key] : Math.Min(lettersMap[key], otherWordMap[key]);
                    }
                    else lettersMap.Remove(key);
                }
            }
            List<string> strings = new List<string>();
            foreach (string key in lettersMap.Keys)
            {
                for (int i = 0; i < lettersMap[key]; i++)
                {
                    strings.Add(key);
                }
            }
            return strings;
        }
    }
}
