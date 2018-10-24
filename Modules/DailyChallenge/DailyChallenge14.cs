using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge14
    {
        /*
         * Given a stream of elements too large to store in memory, pick a random element from the stream with uniform probability.
         */

        public int Proceed(Stream stream)
        {
            Random random = new Random();
            int? result = null;
            int lastRand = -1;
            while(true)
            {
                int readed = stream.ReadByte();
                if (readed == -1)
                {
                    if (result == null)
                    {
                        throw new ArgumentException();
                    }
                    return result.Value;
                }
                int rand = random.Next(0, int.MaxValue);
                if (rand > lastRand)
                {
                    lastRand = rand;
                    result = readed;
                }
            }
        }
    }
}
