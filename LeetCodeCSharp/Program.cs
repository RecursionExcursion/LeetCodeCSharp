// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(UncommonWordsFromTwoSentences.UncommonFromSentences("this apple is sweet", "this apple is sour"));
            Console.WriteLine(UncommonWordsFromTwoSentences.UncommonFromSentences("apple apple", "banana"));

        }
    }
}
