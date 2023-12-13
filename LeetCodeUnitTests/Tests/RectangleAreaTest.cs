using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTests.Tests
{
    internal class RectangleAreaTest
    {
        private RectangleArea rectangleArea = new();

        [Test]
        [TestCase(-3, 0, 3, 4, 0, -1, 9, 2, 45)]
        [TestCase(-2, -2, 2, 2, -2, -2, 2, 2, 16)]
        public void ComputeAreaTest(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2, int expected)
        {
            int actual = rectangleArea.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
