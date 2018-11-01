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
    public class TestDailyChallenge20
    {
        [TestMethod]
        public void DailyChallenge20()
        {
            DailyChallenge20 daily = new DailyChallenge20();
            Assert.AreEqual(2, daily.Proceed(new Tuple<int, int>[]
            {
                new Tuple<int, int>(30,75),
                new Tuple<int, int>(0,50),
                new Tuple<int, int>(60,150),
            }));

            Assert.AreEqual(3, daily.Proceed(new Tuple<int, int>[]
            {
                new Tuple<int, int>(10,15),
                new Tuple<int, int>(0,20),
                new Tuple<int, int>(15,25),
                new Tuple<int, int>(25,50),
                new Tuple<int, int>(5,25),
                new Tuple<int, int>(20,40),
            }));
        }
    }
}
