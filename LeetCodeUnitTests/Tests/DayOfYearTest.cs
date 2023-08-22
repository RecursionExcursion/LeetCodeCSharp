using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    public class DayOfYearTest
    {

        private DayOfYearSol solution;

        [SetUp]
        public void Setup()
        {
            solution = new();
        }

        [Test]
        public void DayofYear()
        {
            Assert.AreEqual(9, solution.DayOfYear("2019-01-09"));
            Assert.AreEqual(41, solution.DayOfYear("2019-02-10"));
        }
    }
}