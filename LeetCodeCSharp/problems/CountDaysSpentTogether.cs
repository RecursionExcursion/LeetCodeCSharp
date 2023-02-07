using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CountDaysSpentTogether
    {
        public static int CountDaysTogether(String arriveAlice, String leaveAlice, String arriveBob, String leaveBob)
        {
            DateTime StringToDate(String date)
            {
                string[] ArrivalString = date.Split("-");
                int[] Arrival = new int[ArrivalString.Length];

                for (int i = 0; i < ArrivalString.Length; i++)
                {
                    Arrival[i] = int.Parse(ArrivalString[i]);
                }
                return new DateTime(1999, Arrival[0], Arrival[1]);
            }

            DateTime aliceArrivalDate = StringToDate(arriveAlice);
            DateTime aliceDepartDate = StringToDate(leaveAlice);

            DateTime bobArrivalDate = StringToDate(arriveBob);
            DateTime bobDepartDate = StringToDate(leaveBob);

            DateTime secondArr = bobArrivalDate < aliceArrivalDate ? aliceArrivalDate : bobArrivalDate;
            DateTime firstDep = bobDepartDate < aliceDepartDate ? bobDepartDate : aliceDepartDate;
            int ans = (int)(firstDep - secondArr).TotalDays + 1;
            return ans > 0 ? ans : 0;

        }
    }
}
