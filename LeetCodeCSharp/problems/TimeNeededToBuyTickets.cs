using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems {
    public class TimeNeededToBuyTickets {
        public static int TimeRequiredToBuy(int[] tickets, int k) {
            //get index 0 current value n
            // n -1
            // if n > 0 move to end of line
            // shift all elements down array repeate 
            // if n !> 0 do not add to end 
            //for each round add 1 second
            //keep track of only your time 
            //break when you index = 0 

            List<int> ticks = new List<int>(tickets);

            int totalTime = 0;

            while (ticks[k] > 0) {
                for (int i = 0; i < ticks.Count && ticks[k] > 0; i++) {
                    if (ticks[i] > 0) {
                        ticks[i]--;
                        totalTime++;
                    }
                }
            }

            return totalTime;

        }
    }
}
