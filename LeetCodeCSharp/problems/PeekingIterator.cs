using System.Drawing;

namespace LeetCodeCSharp.problems
{
    public class PeekingIterator
    {

        private int[] nums;
        private int index = 0;
        private int size = 0;

        public PeekingIterator(IEnumerator<int> iterator)
        {
            int a = 10;
            int n = a;

            nums = new int[n];

            int i = 0;
            void AddNum(int j)
            {
                nums[i++] = j;
                size++;
            }

            AddNum(iterator.Current);
            while (iterator.MoveNext())
            {
                if (size >= n)
                {
                    n += a;
                    int[] temp = new int[n];
                    Array.Copy(nums, temp, nums.Length);
                    nums = temp;
                }


                AddNum(iterator.Current);

            }
        }

        public int Peek()
        {
            return nums[index];
        }

        public int Next()
        {

            return nums[index++];

        }

        public bool HasNext()
        {
            return index < size;
        }
    }
}