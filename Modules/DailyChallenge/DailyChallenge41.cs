using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge41
    {
        /*
        Given a list of integers S and a target number k, write a function that returns a subset of S that adds up to k. If such a subset cannot be made, then return null.
Integers can appear more than once in the list. You may assume all numbers in the list are positive.
For example, given S = [12, 1, 61, 5, 9, 2] and k = 24, return [12, 9, 2, 1] since it sums up to 24.
         */

        public int[] Proceed(int[] input, int k)
        {
            List<int> result = new List<int>();
            if (ProceedIntern(result, input, k))
            {
                return result.ToArray();
            }
            return null;
        }

        private bool ProceedIntern(List<int> result, int[] input, int k)
        {
            foreach(int i in input.Where(x => x <= k))
            {
                int res = k - i;
                if (res == 0)
                {
                    result.Add(i);
                    return true;
                }
                result.Add(i);
                if (ProceedIntern(result, PrepareCollection(input, i, res), res))
                {
                    return true;
                }
                result.RemoveAt(result.Count - 1);
            }
            return false;
        }
    

        private int[] PrepareCollection(int[] current, int currentItem, int k)
        {
            List<int> result = new List<int>();
            bool bFirst = true;
            foreach(int i in current)
            {
                if (i > k)
                {
                    continue;
                }
                if (i == currentItem && bFirst)
                {
                    bFirst = false;
                    continue;
                }
                result.Add(i);
            }
            return result.ToArray();
        }
    }
}
