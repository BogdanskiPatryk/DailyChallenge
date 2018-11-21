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
    public class TestDailyChallenge33
    {
        [TestMethod]
        public void DailyChallenge33()
        {
            DailyChallenge33 daily = new DailyChallenge33();
            Assert.AreEqual("ecarace", daily.Proceed("race"));
            Assert.AreEqual("elgoogle", daily.Proceed("google"));
            Assert.AreEqual("torsrot", daily.Proceed("tosrot"));
            Assert.AreEqual("gloolg", daily.Proceed("gool"));
        }
    }
}
