using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge39
    {
        /*
         * Given an array of integers where every integer occurs three times except for one integer, which only occurs once, find and return the non-duplicated integer.
For example, given [6, 1, 3, 3, 3, 6, 6], return 1. Given [13, 19, 13, 13], return 19.
Do this in O(N) time and O(1) space.
         */

        public int Proceed(int[] input)
        {
            // size of int in C#
            int maxBits = 32;
            int result = 0;
            for (int i = 0; i< maxBits;++i)
            {
                int sum = 0;
                int current = (1 << i);
                foreach (int value in input)
                {
                    if ((value & current) == 0)
                    {
                        sum++;
                    }
                }
                if ((sum % 3) == 0)
                {
                    result |= current;
                }
            }
            return result;
        }
    }
}
