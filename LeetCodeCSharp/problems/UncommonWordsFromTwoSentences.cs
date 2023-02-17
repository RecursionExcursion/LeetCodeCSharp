using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class UncommonWordsFromTwoSentences
    {
        public static string[] UncommonFromSentences(string s1, string s2)
        {

            //Dictionary<String, int> words = new Dictionary<String, int>();
            Dictionary<String, int> words = new();

            void sendStringToMap(String[] strings)
            {
                foreach (String sent in strings)
                {
                    if (words.ContainsKey(sent))
                    {
                        words[sent] += 1;
                    } else
                    {
                        words.Add(sent, 1);
                    }
                }
            }

            sendStringToMap(s1.Split(' '));
            sendStringToMap(s2.Split(' '));

            return words.Keys.Where(key => words[key] == 1).ToArray();
        }
    }
}
