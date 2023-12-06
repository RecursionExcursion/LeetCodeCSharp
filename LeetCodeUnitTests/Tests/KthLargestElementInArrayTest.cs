using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTests.Tests
{
    internal class KthLargestElementInArrayTest
    {

        private KthLargestElementInArray obj = new();


        [Test]
        public void TestKthLargestElementInArray()
        {

            int a = obj.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2);
            int b = obj.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);

            Assert.AreEqual(5, a);
            Assert.AreEqual(4, b);

        }
    }
}
