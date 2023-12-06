using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTests.Tests
{
    internal class CountHillsAndValleysInAnArrayTest
    {

        private CountHillsAndValleysInAnArray obj = new();

        [Test]
        [TestCase(new int[] { 2, 4, 1, 1, 6, 5 }, 3)]
        [TestCase(new int[] { 6, 6, 5, 5, 4, 1 }, 0)]
        public void Test(int[] nums, int expected)
        {
            int result = obj.CountHillValley(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
