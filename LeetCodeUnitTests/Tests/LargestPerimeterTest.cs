using LeetCodeCSharp.problems;


namespace LeetCodeUnitTests.Tests
{
    public class LargestPerimeterTest
    {
        private LargestPerimeterSol largestPerimeter = new();

        [Test]
        public void TestLargestPeriemter()
        {
            Assert.AreEqual(5, largestPerimeter.LargestPerimeter(new int[] { 2, 1, 2 }));
            Assert.AreEqual(0, largestPerimeter.LargestPerimeter(new int[] { 1, 2, 1, 10 }));
            Assert.AreEqual(0, largestPerimeter.LargestPerimeter(new int[] { 1, 2, 1, 10,21,50 }));
        }
    }
}
