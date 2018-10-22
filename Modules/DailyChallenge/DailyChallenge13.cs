using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge13
    {
        public double Proceed(int n)
        {
            Random random = new Random();
            int inCircle = 0;
            for(int i = 0; i <n;++i)
            {
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1;
                if (Math.Pow(x,2) + Math.Pow(y,2) <= 1)
                {
                    inCircle++;
                }
            }
            return 4 * (double)inCircle / n;
        }
    }
}
