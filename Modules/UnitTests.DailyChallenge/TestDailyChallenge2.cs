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
    public class TestDailyChallenge2
    {
        [TestMethod]
        public void DailyChallenge2()
        {
            DailyChallenge2 model = new DailyChallenge2();
            Assert.AreEqual(2, model.Proceed(new int[] { 3, 4, -1, 1 }));
            Assert.AreEqual(3, model.Proceed(new int[] { 1, 2, 0 }));
            Assert.AreEqual(4, model.Proceed(new int[] { 1, 3, 2, 7, 6, -2, 5, -123, 24, 1, 5, 0 }));
            Assert.AreEqual(5, model.Proceed(new int[] { 3, 2, 4, -1, 1 }));
            Assert.AreEqual(5, model.Proceed(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(1, model.Proceed(new int[] { -1, 4, 4, -4 }));
            Assert.AreEqual(1, model.Proceed(new int[] { 2, 2, 2, 2 }));
            Assert.AreEqual(1, model.Proceed(new int[] { 3, 2, 3, 2 }));
        }
    }
}