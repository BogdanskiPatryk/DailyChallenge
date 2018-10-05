using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge0
    {
        /*
         * Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
           For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
           Follow-up: what if you can't use division?
         */

        //public int[] Proceed(int[] input)
        //{
        //    int[] result = new int[input.Length];
        //    for (int index = 0; index < input.Length; ++index)
        //    {
        //        result[index] = Product(input) / input[index];
        //    }
        //    return result;
        //}

        //private int Product(IEnumerable<int> ints)
        //{
        //    int result = 1;
        //    foreach (int i in ints)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        public int[] Proceed(int[] input)
        {
            int[] result = new int[input.Length];
            for (int index = 0; index < input.Length; ++index)
            {
                int pivot = 0;
                result[index] = Product(input.Where(x => pivot++ != index));
            }
            return result;
        }

        private int Product(IEnumerable<int> ints)
        {
            int result = 1;
            foreach (int i in ints)
            {
                result *= i;
            }
            return result;
        }
    }
}