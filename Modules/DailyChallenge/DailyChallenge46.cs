using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge46
    {
        /*
         * Given a array of numbers representing the stock prices of a company in chronological order, write a function that calculates the maximum profit you could have made from buying and selling that stock once. You must buy before you can sell it.
For example, given [9, 11, 8, 5, 7, 10], you should return 5, since you could buy the stock at 5 dollars and sell it at 10 dollars.
         */

        public int Proceed(IEnumerable<int> prices)
        {
            if (prices.Count() <= 1)
            {
                return 0;
            }
            int first = prices.ElementAt(0);
            int max = 0;
            foreach(int price in prices.Skip(1))
            {
                max = Math.Max(max, price - first);
            }
            return Math.Max(max, Proceed(prices.Skip(1)));
        }
    }
}
