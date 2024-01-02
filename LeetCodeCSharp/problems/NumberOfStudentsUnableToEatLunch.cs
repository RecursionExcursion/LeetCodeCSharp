namespace LeetCodeCSharp.problems
{
    public class NumberOfStudentsUnableToEatLunch
    {

        public int CountStudents(int[] students, int[] sandwiches)
        {

            Queue<int> sandQ = new Queue<int>(sandwiches);
            Queue<int> stuQ = new Queue<int>(students);

            int lineSize = stuQ.Count;
            int i = 0;

            while (sandQ.Count > 0)
            {

                int student = stuQ.Dequeue();

                if (student == sandQ.Peek())
                {
                    sandQ.Dequeue();
                    lineSize = stuQ.Count;
                    i = 0;
                }
                else
                {
                    stuQ.Enqueue(student);
                    i++;
                }

                if (i == lineSize)
                {
                    return stuQ.Count;
                }
            }
            return 0;
        }
    }
}
