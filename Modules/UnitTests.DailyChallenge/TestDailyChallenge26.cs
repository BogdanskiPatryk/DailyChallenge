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
    public class TestDailyChallenge26
    {
        [TestMethod]
        public void DailyChallenge26()
        {
            DailyChallenge26 daily = new DailyChallenge26();
            Assert.IsTrue(daily.Proceed("([])[]({})"));
            Assert.IsFalse(daily.Proceed("((()"));
            Assert.IsFalse(daily.Proceed("([)]"));
        }
    }
}
