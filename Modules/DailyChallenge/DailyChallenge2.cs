using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge2
    {
        /*
         * Given an array of integers, find the first missing positive integer in linear time and constant space. In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
You can modify the input array in-place.
         */

        public int Proceed(int[] input)
        {
            int index = 0;
            foreach (int value in input)
            {
                CorrectValue(value, input, index++);
            }
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == i + 1)
                {
                    continue;
                }
                return i + 1;
            }
            return input.Length + 1;
        }

        private void CorrectValue(int value, int[] input, int previousIndex)
        {
            if (value <= 0 || value > input.Length || input[value - 1] == value)
            {
                return;
            }
            int index = value - 1;
            int temp = input[index];
            int tempIndex = temp - 1;
            if (tempIndex == previousIndex)
            {
                // Break infinity loop caused by changing the same pair
                input[index] = value;
                input[previousIndex] = temp;
                return;
            }
            if (temp > 0 && temp <= input.Length)
            {
                // Do not replace importent data
                CorrectValue(temp, input, tempIndex);
            }
            input[index] = value;
        }
    }
}