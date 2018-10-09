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
    public class TestDailyChallenge3
    {
        [TestMethod]
        public void DailyChallenge3()
        {
            DailyChallenge3 obj = new DailyChallenge3();
            Assert.IsTrue(obj.Proceed(new int[] { 10, 15, 3, 7 }, 17));
            Assert.IsTrue(obj.Proceed(new int[] { 10, 15, 3, 7 }, 13));
            Assert.IsTrue(obj.Proceed(new int[] { 10, 15, 3, 7 }, 10));
            Assert.IsFalse(obj.Proceed(new int[] { 10, 15, 3, 7 }, 14));
            Assert.IsFalse(obj.Proceed(new int[] { 10, 15, 3, 7 }, 7));
            Assert.IsTrue(obj.Proceed(new int[] { -5, 15, 3, 7 }, 2));

            Assert.IsTrue(obj.Proceed(new int[] { 1, 1, 1, 5 }, 6));
            Assert.IsTrue(obj.Proceed(new int[] { 1, 1, 1, 5 }, 2));
            Assert.IsFalse(obj.Proceed(new int[] { 1, 1, 1, 5 }, 3));
        }
    }
}