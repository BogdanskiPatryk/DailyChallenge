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
    public class TestDailyChallenge37
    {
        [TestMethod]
        public void DailyChallenge37()
        {
            DailyChallenge37 daily = new DailyChallenge37();
            Assert.AreEqual(1, daily.Proceed(1));
            Assert.AreEqual(0, daily.Proceed(2));
            Assert.AreEqual(0, daily.Proceed(3));
            Assert.AreEqual(2, daily.Proceed(4));
            Assert.AreEqual(10, daily.Proceed(5));
            Assert.AreEqual(724, daily.Proceed(10));
        }
    }
}
