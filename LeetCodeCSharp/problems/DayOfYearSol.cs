namespace LeetCodeCSharp.problems
{
    public class DayOfYearSol
    {
        public int DayOfYear(string date) => DateTime.Parse(date).DayOfYear;

        public int DayOfYear2(string date)
        {
            int[] monthLength = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[] split = date.Split("-");
            int m = int.Parse(split[1]) - 1;
            int d = int.Parse(split[2]);
            int y = int.Parse(split[0]);


            int dayOfYear = (y % 4 == 0)  && (y % 100 == 0 && y % 400 == 0) && (m > 1) ? d + 1 : d;




            while (m != 0)
            {
                dayOfYear += monthLength[--m];
            }

            return dayOfYear;
        }
    }
}
