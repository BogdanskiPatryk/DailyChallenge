using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge32
    {
        /*
         * Compute the running median of a sequence of numbers. That is, given a stream of numbers, print out the median of the list so far on each new element.
Recall that the median of an even-numbered list is the average of the two middle numbers.
For example, given the sequence [2, 1, 5, 7, 2, 0, 5], your algorithm should print out:
2
1.5
2
3.5
2
2
2

         */

        public float[] Proceed(int[] numbers)
        {
            List<float> result = new List<float>();
            List<int> listOfNumbers = new List<int>();
            foreach(int number in numbers)
            {
                listOfNumbers.Add(number);
                listOfNumbers.Sort();
                if (listOfNumbers.Count % 2 == 0)
                {
                    // even
                    float res = (listOfNumbers[listOfNumbers.Count/2 -1] + listOfNumbers[listOfNumbers.Count / 2]) / 2f;
                    result.Add(res);
                }
                else
                {
                    result.Add(listOfNumbers[listOfNumbers.Count / 2]);
                }
            }
            return result.ToArray();
        }
    }
}
