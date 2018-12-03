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
    public class TestDailyChallenge41
    {
        [TestMethod]
        public void DailyChallenge41()
        {
            DailyChallenge41 daily = new DailyChallenge41();
            CollectionAssert.AreEqual(new int[] { 12, 9, 2, 1 }, daily.Proceed(new int[] { 12, 1, 61, 5, 9, 2 }, 24).OrderByDescending(x => x).ToArray());
        }
    }
}
