using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    internal class PeekingIteratorTest
    {


        private PeekingIterator peekingIterator;

        [Test]
        public void TestIteratorPeek()
        {
            List<int> foo = new List<int>() { 1, 2, 3 };
            peekingIterator = new(foo.GetEnumerator());
            Assert.That(0, Is.EqualTo(peekingIterator.Peek()));
        }
    }
}
