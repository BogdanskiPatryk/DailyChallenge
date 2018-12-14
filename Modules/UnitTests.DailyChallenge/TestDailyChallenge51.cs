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
    public class TestDailyChallenge51
    {
        [TestMethod]
        public void DailyChallenge51()
        {
            DailyChallenge51<string, int> daily = new DailyChallenge51<string, int>(3);
            daily.Set("a", 1);
            daily.Set("b", 2);
            daily.Set("c", 3);
            Assert.AreEqual(1, daily.Get("a"));
            Assert.AreEqual(2, daily.Get("b"));
            Assert.AreEqual(3, daily.Get("c"));
            daily.Set("a", 4);
            daily.Set("d", 5);
            Assert.AreEqual(4, daily.Get("a"));
            Assert.AreEqual(5, daily.Get("d"));
            Assert.AreEqual(0, daily.Get("b"));

            daily.Set("e", 1);
            daily.Set("f", 2);
            daily.Set("g", 3);
            Assert.AreEqual(0, daily.Get("a"));
            Assert.AreEqual(0, daily.Get("d"));
            Assert.AreEqual(0, daily.Get("c"));
        }
    }
}
