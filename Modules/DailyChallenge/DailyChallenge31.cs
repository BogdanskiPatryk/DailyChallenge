using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge31
    {
        /*Suppose you are given a table of currency exchange rates, represented as a 2D array. Determine whether there is a possible arbitrage: that is, whether there is some sequence of trades you can make, starting with some amount A of any currency, so that you can end up with some amount greater than A of that currency.
There are no transaction costs and you can trade fractional quantities.
         */ 

        public bool Proceed(float[,] table)
        {
            for(int i = 0; i < table.GetLength(0) - 1;++i)
            {
                for (int k = 0; k < (table.GetLength(0) - (i + 1)); ++k)
                {
                    float sum = 1;
                    int lastJ = i;
                    for (int j = i + k + 1; j < table.GetLength(1); ++j)
                    {
                        sum *= table[lastJ, j];
                        lastJ = j;
                        float res = sum * table[j, i];
                        if (res < 1 - 10 * float.Epsilon || res > 1 + 10 * float.Epsilon)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
