using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge34
    {
        /*
         * Given an array of strictly the characters 'R', 'G', and 'B', segregate the values of the array so that all the Rs come first, the Gs come second, and the Bs come last. You can only swap elements of the array.
Do this in linear time and in-place.
For example, given the array ['G', 'B', 'R', 'R', 'B', 'R', 'G'], it should become ['R', 'R', 'R', 'G', 'G', 'B', 'B'].
         */

        public void Proceed(char[] array)
        {
            int iG = -1;
            int iB = -1;
            for(int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 'R')
                {
                    if (iG == -1 && iB == -1)
                    {
                        continue;
                    }
                    if (iG != -1)
                    {
                        array[iG] = 'R';
                        array[i] = 'G';
                        iG++;
                        if (iB != -1)
                        {
                            array[iB] = 'G';
                            array[i] = 'B';
                            iB++;
                        }
                    }
                    else
                    {
                        array[iB] = 'R';
                        array[i] = 'B';
                        iB++;
                    }
                }
                else if (array[i] == 'G')
                {
                    if (iG == -1)
                    {
                        iG = i;
                    }
                    if (iB != -1)
                    {
                        array[iB] = 'G';
                        array[i] = 'B';
                        iG = iB;
                        iB++;
                    }
                }
                else if (iB == -1)
                {
                    iB = i;
                }
            }
        }

    }
}
