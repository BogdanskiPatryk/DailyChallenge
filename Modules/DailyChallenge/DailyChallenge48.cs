using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge48
    {
        /*
         * Given an array of numbers, find the maximum sum of any contiguous subarray of the array.
For example, given the array [34, -50, 42, 14, -5, 86], the maximum sum would be 137, since we would take elements 42, 14, -5, and 86.
Given the array [-5, -1, -8, -9], the maximum sum would be 0, since we would not take any elements.
Do this in O(N) time.

         */

        public int Proceed(int[] input)
        {
            List<int> result = new List<int>();
            int max = 0;
            foreach(int i in input)
            {
                if (max + i < 0)
                {
                    result.Add(max);
                    max = 0;
                }
                else
                {
                    max += i;
                }
            }
            result.Add(max);
            return result.Max();
        }
    }
}
