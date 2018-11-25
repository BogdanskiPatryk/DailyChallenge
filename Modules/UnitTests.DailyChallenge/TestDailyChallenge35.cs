using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge35;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge35
    {
        [TestMethod]
        public void DailyChallenge35()
        {
            DailyChallenge35 daily = new DailyChallenge35();
            Node root = new Node
            {
                Value = 8,
                Left = new Node
                {
                    Value = 3,
                    Left = new Node()
                    {
                        Value = 1
                    },
                    Right = new Node()
                    {
                        Value = 6,
                        Right = new Node { Value = 7},
                        Left = new Node { Value = 4}
                    }
                },
                Right = new Node()
                {
                    Value = 10,
                    Right = new Node
                    {
                        Value = 14,
                        Left = new Node { Value= 13}
                    }


                }
            };
            Assert.AreEqual(13, daily.Proceed(root));
        }
    }
}
