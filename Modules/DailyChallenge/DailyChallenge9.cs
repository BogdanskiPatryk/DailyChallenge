using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyChallenge
{
    /*
     * Implement a job scheduler which takes in a function f and an integer n, and calls f after n milliseconds.
     */

    public class DailyChallenge9
    {
        public async Task Proceed(Action action, int delayMS, CancellationToken token)
        {
            if (delayMS < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            await Task.Delay(delayMS, token);
            action();
        }

        public Task Proceed2(Action action, int delayMS, CancellationToken token)
        {
            if (delayMS < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Task.Factory.StartNew(async () =>
            {
                await Task.Delay(delayMS, token);
                action();
            }, token);
        }
    }
}