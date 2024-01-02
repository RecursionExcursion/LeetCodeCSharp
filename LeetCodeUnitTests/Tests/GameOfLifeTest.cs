using LeetCodeCSharp.problems;

namespace LeetCodeUnitTests.Tests
{
    public class GameOfLifeTest
    {

        private LifeGame game = new();


        [Test]
        public void TestGameOfLife1()
        {
            int[][] input = new int[][]
            {
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 1 },
               new int[]  { 1, 1, 1 },
               new int[]  { 0, 0, 0 }
            };

            int[][] expected = new int[][]
            {
               new int[] { 0,0,0 },
               new int[] { 1,0,1 },
               new int[] { 0,1,1 },
                new int[] { 0,1,0 }
            };

            game.GameOfLife(input);
            Assert.That(expected, Is.EqualTo(game.board));
        }

        [Test]
        public void TestGameOfLife2()
        {
            int[][] input = new int[][]
            {
             new int[]   { 1,1},
              new int[]  { 1,0 }
            };

            int[][] expected = new int[][]
             {
              new int[]  { 1,1 },
              new int[]  { 1,1 }
            };

            game.GameOfLife(input);
            Assert.That(expected, Is.EqualTo(game.board));
        }
    }
}
