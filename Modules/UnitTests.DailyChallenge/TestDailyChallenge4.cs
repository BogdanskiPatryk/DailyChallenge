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
    public class TestDailyChallenge4
    {
        [TestMethod]
        public void DailyChallenge4()
        {
            DailyChallenge4 daily = new DailyChallenge4();
            Assert.AreEqual(3, daily.Car(daily.Cons(3, 4)));
            Assert.AreEqual(4, daily.Cdr(daily.Cons(3, 4)));
        }
    }
}