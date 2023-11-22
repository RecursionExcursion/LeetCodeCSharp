using LeetCodeCSharp.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTests.Tests
{
    internal class OrderedStreamTest
    {

        [Test]
        public void TestOrderedStream()
        {

            OrderedStream orderedStream = new(5);

            string s1 = "aaaaa";
            string s2 = "bbbbb";
            string s3 = "ccccc";
            string s4 = "ddddd";
            string s5 = "eeeee";

            IList<string> ans1 = orderedStream.Insert(3, s3);
            IList<string> ans2 = orderedStream.Insert(1, s1);
            IList<string> ans3 = orderedStream.Insert(2, s2);
            IList<string> ans4 = orderedStream.Insert(5, s5);
            IList<string> ans5 = orderedStream.Insert(4, s4);


            Assert.True(ans1.SequenceEqual(new List<string>()));
            Assert.True(ans2.SequenceEqual(new List<string>() { s1 }));
            Assert.True(ans3.SequenceEqual(new List<string>() { s2, s3 }));
            Assert.True(ans4.SequenceEqual(new List<string>()));
            Assert.True(ans5.SequenceEqual(new List<string>() { s4, s5 }));


        }
    }
}
