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
    public class TestDailyChallenge39
    {
        [TestMethod]
        public void DailyChallenge39()
        {
            DailyChallenge39 daily = new DailyChallenge39();
            Assert.AreEqual(19, daily.Proceed(new[] { 13, 13, 19, 13 }));
            Assert.AreEqual(1, daily.Proceed(new[] { 6, 1, 3, 3, 3, 6, 6 }));
            Assert.AreEqual(-3, daily.Proceed(new[] { -2, -2, -2, 1, 1, 1, -3 }));
            Assert.AreEqual(int.MaxValue, daily.Proceed(new[] { int.MinValue, int.MinValue, int.MinValue, int.MaxValue}));
            Assert.AreEqual(int.MinValue, daily.Proceed(new[] { int.MaxValue, int.MaxValue, int.MinValue, int.MaxValue }));
            Assert.AreEqual(int.MinValue + 1, daily.Proceed(new[] { int.MaxValue, int.MaxValue, int.MinValue+1, int.MinValue, int.MaxValue, int.MinValue, int.MinValue }));
        }
    }
}
