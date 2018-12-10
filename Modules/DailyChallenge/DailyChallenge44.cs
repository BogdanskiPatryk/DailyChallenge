using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge44
    {
        /*
         * Using a function rand5() that returns an integer from 1 to 5 (inclusive) with uniform probability, implement a function rand7() that returns an integer from 1 to 7 (inclusive).
         */

        public int Proceed()
        {
            // 7*5 
            // Min = 7, Max = 35
            int rand = Rand5();
            rand += Rand5();
            rand += Rand5();
            rand += Rand5();
            rand += Rand5();
            rand += Rand5();
            rand += Rand5();
            return rand % 7 + 1;
        }

        private int Rand5()
        {
            return new Random((int)DateTime.Now.Ticks).Next(1, 6);
        }
    }
}
