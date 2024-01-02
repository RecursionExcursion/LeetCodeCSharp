using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    public class LongestIncreasingSubsequenceTest
    {

        private LongestIncreasingSubsequence lis = new();

        [Test]
        [TestCase(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
        [TestCase(new int[] { 0, 1, 0, 3, 2, 3 }, 4)]
        [TestCase(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 1)]
        public void LISTest(int[] parameters, int expected)
        {
            Assert.That(lis.LengthOfLIS(parameters), Is.EqualTo(expected));
        }

    }
}
