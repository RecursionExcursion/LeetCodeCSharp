// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board1 =
            {
             new char[] { 'A', 'B', 'C', 'E' },
             new char[] { 'S', 'F', 'C', 'S' },
             new char[] { 'A', 'D', 'E', 'E' },
            };


            char[][] board2 =
            {
             new char[] {'A','B','C','E' },
             new char[] {'S','F','C','S' },
             new char[] { 'A','D','E','E' },
            };


            char[][] board3 =
            {
             new char[] {'C','A','A' },
             new char[] {'A','A','A' },
             new char[] { 'B','C','D' },
            };


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(WordSearch.Exist(board1, "ABCCED"));
            Console.WriteLine(WordSearch.Exist(board2, "SEE"));
            Console.WriteLine(WordSearch.Exist(board2, "ABCB"));
            Console.WriteLine(WordSearch.Exist(board3, "AAB"));
        }
    }
}
