using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge34;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge34
    {
        [TestMethod]
        public void DailyChallenge34()
        {
            DailyChallenge34 daily = new DailyChallenge34();
            char[] array = new char[] { 'G', 'B', 'R', 'R', 'B', 'R', 'G' };
            daily.Proceed(array);
            CollectionAssert.AreEqual(new char[] { 'R', 'R', 'R', 'G', 'G', 'B', 'B' }, array);
        }
    }
}
