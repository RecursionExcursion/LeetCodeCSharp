using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    internal class RomanToIntTest
    {
        private RomanToIntSol solution;

        [SetUp]
        public void Setup()
        {
            solution = new();
        }

        [Test]
        public void RomanToInt()
        {
            Assert.AreEqual(58, solution.RomanToInt("LVIII"));
            Assert.AreEqual(3, solution.RomanToInt("III"));
            Assert.AreEqual(1994, solution.RomanToInt("MCMXCIV"));
            Assert.AreEqual(9, solution.RomanToInt("IX"));

        }
    }
}
