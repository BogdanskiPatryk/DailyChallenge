using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge15;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge15
    {
        [TestMethod]
        public void DailyChallenge15()
        {
            DailyChallenge15 daily = new DailyChallenge15(10);
            daily.Record(new Order { ID = Guid.NewGuid() });
            daily.Record(new Order { ID = Guid.NewGuid() });
            daily.Record(new Order { ID = Guid.NewGuid() });
            daily.Record(new Order { ID = Guid.NewGuid() });
            Assert.AreEqual(4, daily.GetLast(10).Length);
            daily.Record(new Order { ID = Guid.NewGuid() });
            daily.Record(new Order { ID = Guid.NewGuid() });
            Assert.AreEqual(6, daily.GetLast(6).Length);
            Assert.AreEqual(3, daily.GetLast(3).Length);
            Guid lastGuid = Guid.NewGuid();
            daily.Record(new Order { ID = lastGuid });
            Assert.AreEqual(lastGuid, daily.GetLast(1)[0].ID);
        }
    }
}
