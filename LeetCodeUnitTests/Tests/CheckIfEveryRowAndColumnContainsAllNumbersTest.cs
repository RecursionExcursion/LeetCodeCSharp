using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    internal class CheckIfEveryRowAndColumnContainsAllNumbersTest
    {

        private CheckIfEveryRowAndColumnContainsAllNumbers obj = new();

        private static readonly int[][] case1 = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 3, 1, 2 },
            new int[] { 2, 3, 1 }
        };

        private static readonly int[][] case2 = new int[][] {
            new int[] { 1,1,1 },
            new int[] { 1,2,3},
            new int[] { 1, 2, 3 }
        };

        [Test]
        public void Test1() => Assert.That(obj.CheckValid(case1));
        [Test]
        public void Test2() => Assert.That(obj.CheckValid(case2), Is.False);




    }
}
