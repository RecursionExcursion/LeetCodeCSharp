using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    internal class CountEvenTest
    {

        private CountEvenSolution countEvenSolution = new();

        [Test]
        public void TestCountEven()
        {
            Assert.AreEqual(2, countEvenSolution.CountEven(4));
            Assert.AreEqual(14, countEvenSolution.CountEven(30));

        }

    }
}
