// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindTheDuplicateNumber.FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
            Console.WriteLine(FindTheDuplicateNumber.FindDuplicate(new int[] { 3, 1, 3, 4, 2 }));

        }
    }
}
