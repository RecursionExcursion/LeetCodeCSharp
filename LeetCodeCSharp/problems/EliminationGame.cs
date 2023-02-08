using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems {
    public class EliminationGame {
        public static int LastRemaining(int n) {

            List<int> result = Enumerable.Range(1, n).ToList();

            Func<List<int>, bool, List<int>> removeInts = (li, boo) => boo || li.Count % 2 != 0 ?
            li.Where((c, index) => index % 2 != 0).ToList() : li.Where((c, index) => index % 2 == 0).ToList();

            bool removeFromFront = true;
            while (result.Count > 1) {
                result = removeInts(result, removeFromFront);
                removeFromFront = !removeFromFront;
            }
            return result[0];
        }
    }
}
