// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(UniqueNumberOfOccurences.UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 }));
            Console.WriteLine(UniqueNumberOfOccurences.UniqueOccurrences(new int[] { 1, 2 }));
            Console.WriteLine(UniqueNumberOfOccurences.UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }));
        }
    }
}
