// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(MaximumNumberOfWordsFoundInSentences.MostWordsFound(new string[] {
                "alice and bob love leetcode", "i think so too", "this is great thanks very much"
            }));

            Console.WriteLine(MaximumNumberOfWordsFoundInSentences.MostWordsFound(new string[] {
              "please wait", "continue to fight", "continue to win"
            }));

        }
    }
}
