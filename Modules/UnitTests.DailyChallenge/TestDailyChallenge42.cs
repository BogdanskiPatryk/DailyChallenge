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
    public class TestDailyChallenge42
    {
        [TestMethod]
        public void DailyChallenge42()
        {
            DailyChallenge42 daily = new DailyChallenge42();
            daily.Push(1);
            Assert.AreEqual(1, daily.Max());
            daily.Push(-2);
            Assert.AreEqual(1, daily.Max());
            daily.Push(5);
            Assert.AreEqual(5, daily.Max());
            daily.Push(15);
            Assert.AreEqual(15, daily.Max());
            Assert.AreEqual(15, daily.Pop());
            Assert.AreEqual(5, daily.Max());
            Assert.AreEqual(5, daily.Pop());
            Assert.AreEqual(1, daily.Max());
            Assert.AreEqual(-2, daily.Pop());
            Assert.AreEqual(1, daily.Max());
            Assert.AreEqual(1, daily.Pop());
        }
    }
}
