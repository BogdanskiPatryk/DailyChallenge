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
    public class TestDailyChallenge11
    {
        [TestMethod]
        public void DailyChallenge11()
        {
            DailyChallenge11 daily = new DailyChallenge11();
            Assert.AreEqual(5, daily.Proceed(4));
            Assert.AreEqual(1, daily.Proceed(1));
            Assert.AreEqual(2, daily.Proceed(2));
            Assert.AreEqual(3, daily.Proceed(3));
            Assert.AreEqual(8, daily.Proceed(5));
        }
    }
}
