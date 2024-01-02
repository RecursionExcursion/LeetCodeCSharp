using LeetCodeCSharp.problems;

namespace LeetCodeCSharp.problems
{
    public class NumberOfStudentsUnableToEatLunchTest
    {

        private NumberOfStudentsUnableToEatLunch studentsEatingLunch = new();


        [Test]
        [TestCase(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }, 0)]
        [TestCase(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }, 3)]
        public void TestNumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches, int expected)
        {
            Assert.That(studentsEatingLunch.CountStudents(students, sandwiches), Is.EqualTo(expected));
        }
    }
}
