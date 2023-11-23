namespace LeetCodeCSharp.problems
{
    public class CountEvenSolution
    {
        public int CountEven(int num)
        {

            int ans = 0;

            for (int i = 2; i <= num; i++)
            {
                if (SumDigits(i) % 2 == 0)
                {
                    ans++;
                }
            }

            return ans;

            int SumDigits(int n)
            {

                int y = 1;

                List<int> digits = new List<int>();

                while (y <= 1000)
                {
                    int i = 0;
                    int testRem = n % (y * 10);
                    while (n % (y * 10) != 0)
                    {
                        n -= y;
                        i++;
                    }
                    digits.Add(i);
                    y *= 10;
                }

                return digits.Sum();
            }

            int GetDigitsFromString(int num)
            {
                int numOfEven = 0;

                for (int i = 2; i <= num; i++)
                {

                    int sum = 0;

                    foreach (var c in i.ToString().ToCharArray())
                    {
                        sum += c - 0;
                    }

                    if (sum % 2 == 0)
                    {
                        numOfEven++;
                    }
                }

                return numOfEven;
            }
        }
    }
}
