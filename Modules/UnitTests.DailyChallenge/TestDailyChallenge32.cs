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
    public class TestDailyChallenge32
    {
        [TestMethod]
        public void DailyChallenge32()
        {
            DailyChallenge32 daily = new DailyChallenge32();
            float[] result = daily.Proceed(new int[] { 2, 1, 5, 7, 2, 0, 5 });
            float[] expected = new float[] { 2, 1.5f, 2, 3.5f, 2, 2, 2 };
            Assert.AreEqual(expected.Length, result.Length);
            for(int i =0;i<result.Length;++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
