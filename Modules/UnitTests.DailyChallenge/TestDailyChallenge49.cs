using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge49;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge49
    {
        [TestMethod]
        public void DailyChallenge49()
        {
            DailyChallenge49 daily = new DailyChallenge49();
            Node root = new Node()
            {
                Value = "*",
                Left = new Node()
                {
                    Value = "+",
                    Left = new Node() { Value = "3" },
                    Right = new Node() { Value = "2" }
                },
                Right = new Node()
                {
                    Value = "+",
                    Left = new Node() { Value = "4" },
                    Right = new Node() { Value = "5" }
                }
            };
            Assert.AreEqual(45, daily.Proceed(root));
        }
    }
}
