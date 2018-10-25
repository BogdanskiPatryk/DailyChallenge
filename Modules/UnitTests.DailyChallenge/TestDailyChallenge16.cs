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
    public class TestDailyChallenge16
    {
        [TestMethod]
        public void DailyChallenge16()
        {
            DailyChallenge16 daily = new DailyChallenge16();
            Assert.AreEqual(32, daily.Proceed("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext"));
        }
    }
}
