// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine(EliminationGame.LastRemaining(9));
        Console.WriteLine(EliminationGame.LastRemaining(20));
        Console.WriteLine(EliminationGame.LastRemaining(6));
        Console.WriteLine(EliminationGame.LastRemaining(1));
        Console.WriteLine(EliminationGame.LastRemaining(100000));
        Console.WriteLine(EliminationGame.LastRemaining(100000000));
        }
    }
}
