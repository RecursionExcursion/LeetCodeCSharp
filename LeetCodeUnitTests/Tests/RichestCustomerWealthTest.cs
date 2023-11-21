using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
namespace LeetCodeUnitTests.Tests
{
    internal class RichestCustomerWealthTest
    {

        private RichestCustomerWealth richestCustomerWealth = new();

        [Test]
        public void TestRichestCustomerWealth()
        {

            int[][] x = new int[2][];
            x[0] = new int[] { 1, 2, 3 };
            x[1] = new int[] { 3, 2, 1 };

            Assert.AreEqual(6, richestCustomerWealth.MaximumWealth(x));

             x = new int[3][];
            x[0] = new int[] { 1,5 };
            x[1] = new int[] { 7,3 };
            x[2] = new int[] { 3,5 };

            Assert.AreEqual(10, richestCustomerWealth.MaximumWealth(x));

            x = new int[3][];
            x[0] = new int[] { 2, 8, 7 };
            x[1] = new int[] { 7, 1, 3 };
            x[2] = new int[] { 1, 9, 5 };

            Assert.AreEqual(17, richestCustomerWealth.MaximumWealth(x));
        }
    }
}
