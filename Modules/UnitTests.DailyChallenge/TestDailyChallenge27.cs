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
    public class TestDailyChallenge27
    {
        /*
         * For example, given the list of words ["the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"] and k = 16, you should return the following:
["the  quick brown", # 1 extra space on the left
"fox  jumps  over", # 2 extra spaces distributed evenly
"the   lazy   dog"] # 4 extra spaces distributed evenly

         */
        [TestMethod]
        public void DailyChallenge27()
        {
            DailyChallenge27 daily = new DailyChallenge27();
            string[] lines = daily.Proceed(new List<string>() { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" }, 16);
            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("the  quick brown", lines[0]);
            Assert.AreEqual("fox  jumps  over", lines[1]);
            Assert.AreEqual("the   lazy   dog", lines[2]);
        }
    }
}
