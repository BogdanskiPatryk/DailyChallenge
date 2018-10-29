using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge18
    {
        [TestMethod]
        public void DailyChallenge18()
        {
            DailyChallenge18 daily = new DailyChallenge18();
            int[] result = daily.Proceed(
                new int[][]
                {
                    new int[]{1,2,3 },
                    new int[]{1,3,3},
                    new int[]{3,4,2},
                });
            int[] expected = new int[] { 1, 0, 2 };
            for(int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
