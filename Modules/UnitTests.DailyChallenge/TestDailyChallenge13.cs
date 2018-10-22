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
    public class TestDailyChallenge13
    {
        [TestMethod]
        public void DailyChallenge13()
        {
            DailyChallenge13 daily = new DailyChallenge13();
            int[] ks = new int[]
                {
                    10,
                    100,
                    1000,
                    10000,
                    100000,
                    1000000,
                };
            foreach(int k in ks)
            {
                double result = daily.Proceed(k);
                Trace.WriteLine($"{result} for {k} samples");
            }
        }
    }
}
