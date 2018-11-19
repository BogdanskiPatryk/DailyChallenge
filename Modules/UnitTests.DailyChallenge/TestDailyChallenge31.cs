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
    public class TestDailyChallenge31
    {
        [TestMethod]
        public void DailyChallenge31()
        {
            DailyChallenge31 daily = new DailyChallenge31();
            Assert.IsFalse(daily.Proceed(new float[,]
            {
                {1, .5f, .25f },
                {2,   1, .5f },
                {4,   2, 1 },
            }));
            Assert.IsTrue(daily.Proceed(new float[,]
            {
                {1, 5, .2f, 10 },
                {2, 1, .5f, .25f },
                {5, 2, 1, .5f },
                {1, 4, 2, 1 },
            }));
        }
    }
}
