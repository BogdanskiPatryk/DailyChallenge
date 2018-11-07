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
    public class TestDailyChallenge24
    {
        [TestMethod]
        public void DailyChallenge24()
        {
            DailyChallenge24 daily = new DailyChallenge24();
            Assert.IsTrue(daily.Proceed("ray", "ra."));
            Assert.IsTrue(daily.Proceed("ray", "ra*"));
            Assert.IsTrue(daily.Proceed("ray", "ray*"));

            Assert.IsFalse(daily.Proceed("raymond", "ra."));
            Assert.IsTrue(daily.Proceed("chat", ".*at"));
            Assert.IsFalse(daily.Proceed("chats", ".*at"));
        }
    }
}
