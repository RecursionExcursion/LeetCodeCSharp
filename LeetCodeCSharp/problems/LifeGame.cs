namespace LeetCodeCSharp.problems
{
    public class LifeGame
    {

        public int[][]? board;

        public void GameOfLife(int[][] board)
        {
            this.board = board;

            //List<Cell> cells = new List<Cell>();
            Dictionary<int, Cell> cells = new();

            int count = 1;
            int h = board.Length;
            int w = board[0].Length;
            int size = h * w;

            for (int i = 0; i < board.Length; i++)
            {

                for (int j = 0; j < board[i].Length; j++)
                {
                    int cellValue = board[i][j];
                    cells.Add(count, new(cellValue, count++));
                }
            }


            foreach (var i in cells)
            {
                int n = i.Key;
                bool isLeft = n - 1 % w == 0;
                bool isRight = n % w == 0;
                bool isTop = n <= w;
                bool isBottom = n > size - w;

                if (w == 1)
                {
                    continue;
                }

                if (!isTop)
                {
                    i.Value.Neighbors.Add(cells[n - w].Life);
                    if (!isLeft)
                    {
                        i.Value.Neighbors.Add(cells[n - (w + 1)].Life);
                    }
                    if (!isRight)
                    {
                        i.Value.Neighbors.Add(cells[n - (w - 1)].Life);
                    }
                }
                if (!isBottom)
                {
                    i.Value.Neighbors.Add(cells[n + w].Life);
                    if (!isLeft)
                    {
                        i.Value.Neighbors.Add(cells[n + (w - 1)].Life);
                    }
                    if (!isRight)
                    {
                        i.Value.Neighbors.Add(cells[n + (w + 1)].Life);
                    }
                }
                if (!isLeft)
                {
                    i.Value.Neighbors.Add(cells[n - 1].Life);
                }
                if (!isRight)
                {
                    i.Value.Neighbors.Add(cells[n + 1].Life);
                }

            }


            foreach (var cell in cells.Values)
            {
                cell.ApplyNewState();
            }


            count = 1;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = cells[count++].Life;
                }
            }
        }


        class Cell
        {
            public List<int> Neighbors { get; set; } = new();
            public int Life { get; set; }
            public int CellNumber { get; }

            public Cell(int life, int num)
            {
                Life = life;
                CellNumber = num;
            }

            public void ApplyNewState()
            {
                int neighbors = Neighbors.Sum();
                if (Life == 1)
                {

                    if (neighbors < 2 || neighbors > 3)
                    {
                        Life = 0;
                    }
                }
                else
                {
                    if (neighbors == 3)
                    {
                        Life = 1;
                    }
                }
            }
        }
    }
}
