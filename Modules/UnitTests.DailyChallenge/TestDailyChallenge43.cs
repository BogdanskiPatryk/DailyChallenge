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
    public class TestDailyChallenge43
    {
        [TestMethod]
        public void DailyChallenge43()
        {
            DailyChallenge43 daily = new DailyChallenge43();
            Assert.AreEqual(10, daily.Proceed( new int[] { 5, 4, 3, 2, 1 }));
            Assert.AreEqual(3, daily.Proceed(new int[] { 2, 4, 1, 3, 5 }));
        }
    }
}
