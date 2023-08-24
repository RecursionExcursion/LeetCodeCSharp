using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.AreEqual(3, solution.RomanToInt("III"));
            Assert.AreEqual(58, solution.RomanToInt("LVIII"));
            Assert.AreEqual(1994, solution.RomanToInt("MCMXCIV"));

        }
    }
}
