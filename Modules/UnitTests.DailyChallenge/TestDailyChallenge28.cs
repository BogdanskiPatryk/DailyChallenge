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
    public class TestDailyChallenge28
    {
        [TestMethod]
        public void DailyChallenge28()
        {
            DailyChallenge28 daily = new DailyChallenge28();
            Assert.AreEqual("4A3B2C1D2A", daily.Encode("AAAABBBCCDAA"));
            Assert.AreEqual("AAAABBBCCDAA", daily.Decode("4A3B2C1D2A"));
        }
    }
}
