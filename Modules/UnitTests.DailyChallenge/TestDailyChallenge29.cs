using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge29
    {
        [TestMethod]
        public void DailyChallenge29()
        {
            DailyChallenge29 daily = new DailyChallenge29();
            Assert.AreEqual(1, daily.Proceed(new int[] { 2, 1, 2 }));
            Assert.AreEqual(8, daily.Proceed(new int[] { 3, 0, 1, 3, 0, 5 }));
            Assert.AreEqual(0, daily.Proceed(new int[] { 2,3,4,5,6,5,4,3,2}));
            Assert.AreEqual(30, daily.Proceed(new int[] { 4, 3, 0, 0, 3, 0, 0, 2, 0, 0, 2, 4 }));
        }

        [TestMethod]
        [Ignore]
        public void DailyChallenge29_Performance()
        {
            int[] len = new int[] { 100000, 1000000};
            DailyChallenge29 daily = new DailyChallenge29();
            Stopwatch[] sws = new Stopwatch[2]
            {
                new Stopwatch(), new Stopwatch() 
            };
            for(int l = 0; l <len.Length; ++l)
            {
                for (int k = 0; k < 3; ++k)
                {
                    int value = len[l] / 2;
                    int[] test = new int[len[l]];
                    for (int i = 0; i < test.Length; i++)
                    {
                        test[i] = Math.Abs(value);
                        value--;
                    }
                    sws[l].Start();
                    daily.Proceed(test);
                    sws[l].Stop();
                }
            }
            Trace.WriteLine($"For 100000: {sws[0].ElapsedTicks / 3}");
            Trace.WriteLine($"For 1000000: {sws[1].ElapsedTicks / 3}");

        }
    }
}
