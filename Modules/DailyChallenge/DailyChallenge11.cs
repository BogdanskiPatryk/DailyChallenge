using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge11
    {
        /*
         * There exists a staircase with N steps, and you can climb up either 1 or 2 steps at a time. Given N, write a function that returns the number of unique ways you can climb the staircase. The order of the steps matters.
            For example, if N is 4, then there are 5 unique ways:
            •	1, 1, 1, 1
            •	2, 1, 1
            •	1, 2, 1
            •	1, 1, 2
            •	2, 2
            What if, instead of being able to climb 1 or 2 steps at a time, you could climb any number from a set of positive integers X? For example, if X = {1, 3, 5}, you could climb 1, 3, or 5 steps at a time.
         */

        public int Proceed(int steps)
        {
            if (steps == 0)
            {
                return 0;
            }
            return ProceedIntern(steps);
        }

        private int ProceedIntern(int stepsLeft)
        {
            if (stepsLeft == 1)
            {
                // only '1'
                return 1;
            }
            if (stepsLeft == 2)
            {
                // '11' and '2'
                return 2;
            }
            int result = 0;
            // '1' And ??
            result += ProceedIntern(stepsLeft - 1);
            // '2' And ??
            result += ProceedIntern(stepsLeft - 2);
            return result;
        }
    }
}
