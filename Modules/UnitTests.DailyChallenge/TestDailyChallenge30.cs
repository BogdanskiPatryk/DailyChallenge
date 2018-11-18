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
    public class TestDailyChallenge30
    {
        [TestMethod]
        public void DailyChallenge30()
        {
            DailyChallenge30 daily = new DailyChallenge30();
            Assert.AreEqual(3, daily.Proceed("kitten", "sitting"));
            Assert.AreEqual(1, daily.Proceed("abcdef", "abcydef"));
            Assert.AreEqual(1, daily.Proceed("abcdef", "abdef"));
        }
    }
}
