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
    public class TestDailyChallenge12
    {
        [TestMethod]
        public void DailyChallenge12()
        {
            DailyChallenge12 daily = new DailyChallenge12();
            Assert.AreEqual("bcb", daily.Proceed("abcba", 2));
            Assert.AreEqual("jasfjaf", daily.Proceed("lijasfjafwlajsd", 4));
        }
    }
}
