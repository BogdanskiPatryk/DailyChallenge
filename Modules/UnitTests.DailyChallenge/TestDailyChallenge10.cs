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
    public class TestDailyChallenge10
    {
        [TestMethod]
        public void DailyChallenge10()
        {
            DailyChallenge10 daily = new DailyChallenge10(new string[] { "dog", "deer", "deal" });
            var result = daily.Proceed("de").ToList();
            Assert.IsTrue(result.Contains("deer"));
            Assert.IsTrue(result.Contains("deal"));
            Assert.AreEqual(2, result.Count);
        }
    }
}
