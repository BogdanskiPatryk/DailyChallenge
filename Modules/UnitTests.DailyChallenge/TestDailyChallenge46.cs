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
    public class TestDailyChallenge46
    {
        [TestMethod]
        public void DailyChallenge46()
        {
            DailyChallenge46 daily = new DailyChallenge46();
            Assert.AreEqual(5, daily.Proceed(new int[] { 9, 11, 8, 5, 7, 10 }));
        }
    }
}
