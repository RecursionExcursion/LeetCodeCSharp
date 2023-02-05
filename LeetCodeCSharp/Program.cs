// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };


            string s2 = "abc";
            int[] indices2 = { 0, 1, 2 };


        Console.WriteLine(ShuffleString.RestoreString(s,indices));
        Console.WriteLine(ShuffleString.RestoreString(s2,indices2));

        }
    }
}
