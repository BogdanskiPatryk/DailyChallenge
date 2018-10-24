using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge14
    {
        [TestMethod]
        public void DailyChallenge14()
        {
            DailyChallenge14 daily = new DailyChallenge14();
            using (Stream s = new MemoryStream(new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }))
            {
                daily.Proceed(s);
                    }
        }
    }
}
