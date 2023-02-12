using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems {
    public class MostFrequentEvenElement {
        public static int MostFrequentEven(int[] nums) {


            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int num in nums) {
                if (num % 2 == 0) {
                    if (dic.ContainsKey(num)) {
                        dic[num]++;
                    } else {
                        dic.Add(num, 1);

                    }
                }
            }

            int ans = -1;
            foreach (int key in dic.Keys) {

                if(!dic.ContainsKey(ans)) {
                    ans = key;
                    continue;
                }

                ans = dic[key] >= dic[ans] ?
                    dic[key] == dic[ans] ? 
                        key < ans ? key : ans 
                        : key :
                    ans;

            }
            return ans;

        }
    }
}