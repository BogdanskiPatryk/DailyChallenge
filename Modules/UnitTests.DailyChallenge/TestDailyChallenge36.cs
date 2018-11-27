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
    public class TestDailyChallenge36
    {
        [TestMethod]
        public void DailyChallenge36()
        {
            DailyChallenge36 daily = new DailyChallenge36();
            List<List<int>> result = daily.Proceed(new int[] { 1, 2, 3 });
            Assert.AreEqual(8, result.Count);
            Assert.IsTrue(result.Any(x => x.Count == 0));
            Assert.IsTrue(result.Any(x => x.Count == 1 && x[0] == 1));
            Assert.IsTrue(result.Any(x => x.Count == 1 && x[0] == 1));
            Assert.IsTrue(result.Any(x => x.Count == 1 && x[0] == 1));
            Assert.IsTrue(result.Any(x => x.Count == 2 && x[0] == 1 && x[1] == 2));
            Assert.IsTrue(result.Any(x => x.Count == 2 && x[0] == 1 && x[1] == 3));
            Assert.IsTrue(result.Any(x => x.Count == 2 && x[0] == 1 && x[1] == 2));
            Assert.IsTrue(result.Any(x => x.Count == 3 && x[0] == 1 && x[1] == 2 && x[2] == 3));
        }
    }
}
