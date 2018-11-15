using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge29
    {
        /*
         * You are given an array of non-negative integers that represents a two-dimensional elevation map where each element is unit-width wall and the integer is the height. Suppose it will rain and all spots between two walls get filled up.
Compute how many units of water remain trapped on the map in O(N) time and O(1) space.
For example, given the input [2, 1, 2], we can hold 1 unit of water in the middle.
Given the input [3, 0, 1, 3, 0, 5], we can hold 3 units in the first index, 2 in the second, and 3 in the fourth index (we cannot hold 5 since it would run off to the left), so we can trap 8 units of water.
         */


        //public int Proceed(int[] map)
        //{
        //    int result = 0;
        //    int start = 0;
        //    int max = map[0];
        //    for (int i = 1; i < map.Length; ++i)
        //    {
        //        if (map[i] <= map[i - 1])
        //        {
        //            continue;
        //        }
        //        if (start == i - 1 && map[i] >= max)
        //        {
        //            max = map[i];
        //            start = i;
        //            continue;
        //        }
        //        int maximum = Math.Min(max, map[i]);
        //        for (int k = i - 1; k >= start; --k)
        //        {
        //            if (map[k] < maximum)
        //            {
        //                result += maximum - map[k];
        //                map[k] = maximum;
        //                continue;
        //            }
        //            break;
        //        }
        //        if (max < map[i])
        //        {
        //            max = map[i];
        //            start = i;
        //        }
        //    }

        //    return result;
        //}

        public int Proceed(int[] map)
        {
            int result = 0;
            int lMax = 0;
            int rMax = 0;
            int left = 0;
            int right = map.Length - 1;

            while (left <= right)
            {
                if (map[left] < map[right])
                {
                    if (map[left] > lMax)
                    {
                        lMax = map[left];
                    }
                    else
                    {
                        result += lMax - map[left];
                    }
                    left++;
                }
                else
                {
                    if (map[right] > rMax)
                    {
                        rMax = map[right];
                    }
                    else
                    {
                        result += rMax - map[right];
                    }
                    right--;
                }
            }
            return result;
        }
    }
}
