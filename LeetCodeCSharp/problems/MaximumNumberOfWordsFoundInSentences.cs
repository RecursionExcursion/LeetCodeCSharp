using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems {
    public class MaximumNumberOfWordsFoundInSentences {
        public static int MostWordsFound(string[] sentences) => sentences.Select(s => s.Split(' ').Length).MaxBy(x);

        /*
        public static int MostWordsFound(string[] sentences) {

            int count = 0;
            foreach (string sentence in sentences) {
                string[] words = sentence.Split(' ');
                count = count > words.Length ? count : words.Length;
            }

            return count;
        }
        */
    }
}

