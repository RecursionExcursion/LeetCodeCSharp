namespace LeetCodeCSharp.problems
{
    public class RomanToIntSol
    {
        public int RomanToInt(string s)
        {

            char[] charArry = s.ToCharArray();

            Queue<char> queue = new Queue<char>(charArry);

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

            Func<int> peekToInt = () => stringToInt(queue.Peek());
            Func<bool> queueIsNotEmpty = () => queue.Count > 0;

            Func<int, int> doTheThing = (x) =>
            {
                return stringToInt(queue.Dequeue()) - (2 * x);
            };


            while (queueIsNotEmpty())
            {
                int currentInt = stringToInt(queue.Dequeue());
                returnValue += currentInt;


                if (queueIsNotEmpty())
                {

                    if (currentInt == 100 && (peekToInt() == 500 || peekToInt() == 1000))
                    {
                        returnValue += doTheThing(100);
                    }
                    else if (currentInt == 10 && (peekToInt() == 50 || peekToInt() == 100))
                    {
                        returnValue += doTheThing(10);
                    }
                    else if (currentInt == 1 && peekToInt() == 5)
                    {
                        returnValue += doTheThing(1);
                    }
                }
            }
            return returnValue;
        }
    }
}
