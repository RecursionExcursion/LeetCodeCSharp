using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    internal class CountOfMatchesInTournamentTest
    {

        private CountOfMatchesInTournament countOfMatches = new();

        [Test]
        public void NumberOfMatchesTest()
        {
            Assert.AreEqual(6, countOfMatches.NumberOfMatches(7));
            Assert.AreEqual(13, countOfMatches.NumberOfMatches(14));
        }
    }
}
