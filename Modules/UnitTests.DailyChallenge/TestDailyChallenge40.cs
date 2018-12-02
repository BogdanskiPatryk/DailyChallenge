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
    public class TestDailyChallenge40
    {
        [TestMethod]
        public void DailyChallenge40()
        {
            DailyChallenge40 daily = new DailyChallenge40();
            CollectionAssert.AreEqual(new string[] { "YUL", "YYZ", "SFO", "HKO", "ORD" }, daily.Proceed(new[]
            {
                new  Tuple<string,string>("SFO", "HKO"), new  Tuple<string,string>("YYZ", "SFO"), new  Tuple<string,string>("YUL", "YYZ"), new  Tuple<string,string>("HKO", "ORD")
            }, "YUL"));
            Assert.IsNull(daily.Proceed(new[]
            {
                new  Tuple<string,string>("SFO", "COM"), new  Tuple<string,string>("COM", "YYZ"),
            }, "COM"));
            CollectionAssert.AreEqual(new string[] { "A", "B", "C", "A", "C" }, daily.Proceed(new[]
            {
                new  Tuple<string,string>("A", "B"), new  Tuple<string,string>("A", "C"), new  Tuple<string,string>("B", "C"), new  Tuple<string,string>("C", "A")
            }, "A"));
        }
    }
}
