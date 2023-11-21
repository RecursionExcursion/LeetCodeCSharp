namespace LeetCodeCSharp.problems
{
    public class RomanToIntSol
    {
        public int RomanToInt(string s)
        {

            int returnValue = 0;

            Func<char, int> stringToInt = x =>
            {
                return x switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => 0,
                };
            };
           
            Queue<int> queue = new();

            foreach (char c in s.ToCharArray())
            { 
                queue.Enqueue(stringToInt(c));
            }

            Func<bool> queueIsNotEmpty = () => queue.Count > 0;
            Func<int, int> adjustVal = (x) => queue.Dequeue() - (2 * x);

            while (queueIsNotEmpty())
            {
                int currentInt = queue.Dequeue();
                returnValue += currentInt;

                if (queueIsNotEmpty())
                {
                    if (currentInt == 100 && (queue.Peek() == 500 || queue.Peek() == 1000))
                    {
                        returnValue += adjustVal(100);
                    }
                    else if (currentInt == 10 && (queue.Peek() == 50 || queue.Peek() == 100))
                    {
                        returnValue += adjustVal(10);
                    }
                    else if (currentInt == 1 && (queue.Peek() == 5 || queue.Peek() == 10))
                    {
                        returnValue += adjustVal(1);
                    }
                }
            }
            return returnValue;
        }
    }
}
