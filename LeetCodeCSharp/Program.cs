// See https://aka.ms/new-console-template for more information


using LeetCodeCSharp.problems;

namespace LeetCodeCSharp {
    class Program {
        static void Main(string[] args) {

            ExcelSheet excelSheet = new();


            Console.WriteLine(excelSheet.TitleToNumber("A"));
            Console.WriteLine(excelSheet.TitleToNumber("AB"));
            Console.WriteLine(excelSheet.TitleToNumber("ZY"));
     
        }
    }
}
