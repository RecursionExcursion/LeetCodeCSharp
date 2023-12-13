using System.Reflection.PortableExecutable;

namespace LeetCodeCSharp.problems
{
    public class RectangleArea
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {

            List<int[]> coords2 = new();

            FillSet(ax1, ay1, ax2, ay2);
            FillSet(bx1, by1, bx2, by2);

            return coords2.Count;

            void FillSet(int x1, int y1, int x2, int y2)
            {

                int xDiff = x2 - x1;
                int yDiff = y2 - y1;

                for (int x = x1; x < x1 + xDiff; x = xDiff > 0 ? ++x : --x)
                {
                    for (int y = y1; y < y1 + yDiff; y = yDiff > 0 ? ++y : --y)
                    {
                        AddCoord(x, y);
                    }
                }
            }

            void AddCoord(int x, int y)
            {
                foreach (var coord in coords2)
                {
                    if (coord[0] == x && coord[1] == y)
                    {
                        return;
                    }
                }
                coords2.Add(new int[] { x, y });
            }
        }
    }

    /*
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {

        HashSet<Coord> coords = new();

        FillSet(coords, new Coord(ax1, ay1), new Coord(ax2, ay2));
        FillSet(coords, new Coord(bx1, by1), new Coord(bx2, by2));

        return coords.Count;

        static void FillSet(HashSet<Coord> coords, Coord a, Coord b)
        {

            int xDiff = b.X - a.X;
            int yDiff = b.Y - a.Y;

            for (int x = a.X; x < a.X + xDiff; x = xDiff > 0 ? ++x : --x)
            {
                for (int y = a.Y; y < a.Y + yDiff; y = yDiff > 0 ? ++y : --y)
                {
                    coords.Add(new Coord(x, y));
                }
            }
        }
    }
    class Coord
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Coord otherCoord)
            {
                return false;
            }
            return X == otherCoord.X && Y == otherCoord.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
    */
}

