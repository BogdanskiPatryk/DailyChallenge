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
    public class TestDailyChallenge6
    {
        [TestMethod]
        public void DailyChallenge6()
        {
            DailyChallenge6 daily = new DailyChallenge6();
            Assert.AreEqual(3, daily.Proceed("111"));
            Assert.AreEqual(1, daily.Proceed("1"));
            Assert.AreEqual(2, daily.Proceed("11"));

            Assert.AreEqual(2, daily.Proceed("26"));
            Assert.AreEqual(1, daily.Proceed("32"));
            Assert.AreEqual(8, daily.Proceed("11111"));
            Assert.AreEqual(1, daily.Proceed("54"));
            Assert.AreEqual(3, daily.Proceed("5111"));
        }
    }
}