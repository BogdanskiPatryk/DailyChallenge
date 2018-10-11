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
    public class TestDailyChallenge5
    {
        [TestMethod]
        public void DailyChallenge5()
        {
            DailyChallenge5 daily = new DailyChallenge5();
            daily.Add(12);
            daily.Add(15);
            daily.Add(27);
            daily.Add(89);

            Assert.AreEqual(12, daily.Get(0));
            Assert.AreEqual(15, daily.Get(1));
            Assert.AreEqual(27, daily.Get(2));
            Assert.AreEqual(89, daily.Get(3));
        }
    }
}