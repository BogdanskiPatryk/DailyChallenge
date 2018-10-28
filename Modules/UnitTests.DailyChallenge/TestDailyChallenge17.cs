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
    public class TestDailyChallenge17
    {
        [TestMethod]
        public void DailyChallenge17()
        {
            DailyChallenge17 daily = new DailyChallenge17();
            int[] result = daily.Proceed(new int[] { 10, 5, 2, 7, 8, 7 },3);
            int[] expected = new int[] { 10, 7, 8, 8 };
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
            result = daily.Proceed(new int[] { 10, 5, 2, 7, 8, 7, 12, 9 }, 4);
            expected = new int[] { 10, 8, 8, 12,12 };
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

            result = daily.Proceed(new int[] { 10, 5 , 6, 1, 13, 8, 7, 9, 17, 2, 2, 16, 18, 1, 5, 3, 2, 7, 11},5);
            expected = new int[] { 13, 13, 13, 13, 17, 17, 17, 17, 18, 18, 18, 18, 18, 7, 11 };
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void DailyChallenge17_Compare()
        {
            DailyChallenge17 daily = new DailyChallenge17();
            int n = 10000;
            int[] test_0 = Generate(n);
            int[] expected = daily.ProceedOld(test_0, 15);
            int[] result = daily.Proceed(test_0, 15);
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i], $"Fail on {i}");
            }

        }

        [TestMethod]
        public void DailyChallenge17_Perf()
        {
            DailyChallenge17 daily = new DailyChallenge17();
            int n = 10000000;
            Random random = new Random();
            int[] test_0 = Generate(n);
            int[] test_1 = Generate(n * 2);
            int[] test_2 = Generate(n * 4);
            long sw_0, sw_1, sw_2;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            daily.Proceed(test_0, 12);
            stopwatch.Stop();
            sw_0 = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();
            daily.Proceed(test_1, 12);
            stopwatch.Stop();
            sw_1 = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();
            daily.Proceed(test_2, 12);
            stopwatch.Stop();
            sw_2 = stopwatch.ElapsedMilliseconds;

            Trace.WriteLine($"For {n}: {sw_0} ms");
            Trace.WriteLine($"For {n * 2}: {sw_1} ms");
            Trace.WriteLine($"For {n * 4}: {sw_2} ms");

            Trace.WriteLine($"*2, time *{sw_1 / (float)sw_0}");
            Trace.WriteLine($"*4, time *{sw_2 / (float)sw_0}");

        }

        private int[] Generate(int n)
        {
            Random random = new Random();
            int[] result = new int[n];
            for(int i = 0; i< n; ++i)
            {
                result[i] = random.Next(1, 1000);
            }
            return result;
        }
    }
}
