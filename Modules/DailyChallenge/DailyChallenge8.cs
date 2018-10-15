using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge8
    {
        /*
         * Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. Numbers can be 0 or negative.
For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10, since we pick 5 and 5.

         */

        public int Proceed(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            return ProceedInternal(array);
        }

        private int ProceedInternal(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            if (array.Length == 1)
            {
                return array[0];
            }
            if (array.Length == 2)
            {
                return Math.Max(array[0], array[1]);
            }
            int sumFirst = array[0] + ProceedInternal(array.Skip(2).ToArray());
            int sumSecond = array[1] + ProceedInternal(array.Skip(3).ToArray());
            return Math.Max(sumFirst, sumSecond);
        }
    }
}