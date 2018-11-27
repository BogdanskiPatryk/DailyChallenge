using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge36
    {
        /*
         * The power set of a set is the set of all its subsets. Write a function that, given a set, generates its power set.
For example, given the set {1, 2, 3}, it should return {{}, {1}, {2}, {3}, {1, 2}, {1, 3}, {2, 3}, {1, 2, 3}}.
You may also use a list or array to represent a set.

         */

        public List<List<int>> Proceed(IEnumerable<int> input)
        {
            return ProceedIntern(input);
        }

        private List<List<int>> ProceedIntern(IEnumerable<int> input)
        {
            List<List<int>> result = new List<List<int>>();
            int count = input.Count();
            for (int i = 0; i < count; ++i)
            {
                foreach(var rest in ProceedIntern(input.Skip(i+1).ToList()))
                {
                    List<int> res = new List<int>() { input.ElementAt(i) };
                    res.AddRange(rest);
                    result.Add(res);
                }
            }
            result.Add(new List<int>());
            return result;
        }
    }
}
