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
    public class TestDailyChallenge8
    {
        [TestMethod]
        public void DailyChallenge8()
        {
            DailyChallenge8 daily = new DailyChallenge8();
            Assert.AreEqual(13, daily.Proceed(new int[] { 2, 4, 6, 2, 5 }));
            Assert.AreEqual(10, daily.Proceed(new int[] { 5, 1, 1, 5 }));
            Assert.AreEqual(3, daily.Proceed(new int[] { 1, 1, 1, 1, 1, 1 }));
            Assert.AreEqual(9, daily.Proceed(new int[] { 1, 2, 3, 4, 5, -6 }));
            Assert.AreEqual(9, daily.Proceed(new int[] { 0, 0, 3, 0, 0, 3, 0, 0, 3 }));
        }
    }
}