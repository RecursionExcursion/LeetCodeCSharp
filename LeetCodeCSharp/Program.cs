// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 5, 3 };
            int[] arr2 = { 3, 1, 7, 11 };

            Console.WriteLine(CheckIfNAndItsDoublesExist.CheckIfExist(arr));
            Console.WriteLine(CheckIfNAndItsDoublesExist.CheckIfExist(arr2));
        }
    }
}
