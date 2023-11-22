using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class OrderedStream
    {

        private IList<string> stream;
        private int pointer = 0;

        public OrderedStream(int n)
        {
            stream = Enumerable.Repeat<string>(null, n).ToList();
        }

        public IList<string> Insert(int idKey, string value)
        {
            stream[idKey - 1] = value;

            IList<string> result = new List<string>();

            for (; pointer < stream.Count; pointer++)
            {
                if (stream[pointer] != null)
                    result.Add(stream[pointer]);
                else
                    break;
            }

            return result;
        }
    }
}
