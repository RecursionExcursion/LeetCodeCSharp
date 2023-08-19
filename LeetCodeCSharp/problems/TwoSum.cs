namespace LeetCodeCSharp.problems
{
    public static class TwoSum
    {
        internal static int[] FindTwoSum(int[] ints, int target)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for (int k = i + 1; k < ints.Length; k++)
                {
                    if (ints[i] + ints[k] == target)
                    {
                        return (new int[] { i, k });
                    }
                }
            }
            return null;
        }
    }
}
