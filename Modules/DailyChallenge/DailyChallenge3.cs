using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge3
    {
        /*
         * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
Bonus: Can you do this in one pass?

         */

        public bool Proceed(int[] input, int toCheck)
        {
            HashSet<int> already = new HashSet<int>();
            foreach (int value in input)
            {
                int sub = toCheck - value;
                if (already.Contains(sub))
                {
                    return true;
                }
                already.Add(value);
            }
            return false;
        }
    }
}