using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge22;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge22
    {

        [TestMethod]
        public void DailyChallenge22()
        {
            DailyChallenge22 daily = new DailyChallenge22();
            Assert.AreEqual(7, daily.Proceed(new bool[][]
            {
                new bool[]{false,false,false,false },
                new bool[]{true,true,false,true },
                new bool[]{false,false,false,false },
                new bool[]{false,false,false,false },
            }, new Point { Row = 3, Col = 0 }, new Point { Row = 0, Col = 0 }));
        }
    }
}
