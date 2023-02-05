// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "bella", "label", "roller" };
            string[] words2 = { "cool", "lock", "cook" };

        


            foreach (string word in FindCommonCharacters.CommonChars(words))
            {
                Console.Write(word);
            }

            foreach (string word in FindCommonCharacters.CommonChars(words2))
            {
                Console.Write(word);
            }





        }
    }
}
