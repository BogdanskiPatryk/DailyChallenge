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
    public class TestDailyChallenge52
    {
        [TestMethod]
        public void DailyChallenge52()
        {
            DailyChallenge52 daily = new DailyChallenge52();
            daily.Enqueue(1);
            daily.Enqueue(2);
            daily.Enqueue(3);
            Assert.AreEqual(1, daily.Dequeue());
            Assert.AreEqual(2, daily.Dequeue());
            Assert.AreEqual(3, daily.Dequeue());
        }
        
    }
}
