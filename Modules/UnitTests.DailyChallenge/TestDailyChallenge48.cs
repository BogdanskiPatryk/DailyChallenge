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
    public class TestDailyChallenge48
    {
        [TestMethod]
        public void DailyChallenge48()
        {
            DailyChallenge48 daily = new DailyChallenge48();
            Assert.AreEqual(137, daily.Proceed(new int[] { 34, -50, 42, 14, -5, 86 }));
            Assert.AreEqual(0, daily.Proceed(new int[] {-5, -1, -8, -9}));
        }
    }
}
