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
    public class TestDailyChallenge45
    {
        [TestMethod]
        public void DailyChallenge45()
        {
            DailyChallenge45 daily = new DailyChallenge45();
            Assert.AreEqual("bcdcb", daily.Proceed("aabcdcb"));
            Assert.AreEqual("anana", daily.Proceed("bananas"));
        }
    }
}
