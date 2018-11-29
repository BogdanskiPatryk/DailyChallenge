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
    public class TestDailyChallenge38
    {
        [TestMethod]
        public void DailyChallenge38()
        {
            DailyChallenge38 daily = new DailyChallenge38(new Tuple<int, int>[] { new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 2) ,new Tuple<int, int>(3, 3), new Tuple<int, int>(3, 4), new Tuple<int, int>(4, 4), new Tuple<int, int>(4, 3), new Tuple<int, int>(2, 3) });
            daily.Proceed(5);
        }
    }
}
