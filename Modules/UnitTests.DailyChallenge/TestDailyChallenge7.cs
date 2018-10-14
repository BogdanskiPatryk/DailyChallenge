using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge7;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge7
    {
        [TestMethod]
        public void DailyChallenge7()
        {
            DailyChallenge7 daily = new DailyChallenge7();
            Node root1 = new Node()
            {
                Value = 0,
                Left = new Node() { Value = 1 },
                Right = new Node()
                {
                    Value = 0,
                    Right = new Node() { Value = 0 },
                    Left = new Node()
                    {
                        Value = 1,
                        Right = new Node() { Value = 1 },
                        Left = new Node() { Value = 1 }
                    }
                }
            };
            Node root2 = new Node()
            {
                Value = 0,
                Left = new Node() { Value = 0 },
                Right = new Node()
                {
                    Value = 0,
                    Right = new Node() { Value = 0 },
                    Left = new Node()
                    {
                        Value = 0,
                        Right = new Node() { Value = 1 },
                        Left = new Node()
                        {
                            Value = 1,
                            Right = new Node { Value = 1 },
                            Left = new Node { Value = 1 },
                        }
                    }
                }
            };
            Assert.AreEqual(5, daily.Proceed(root1));
            Assert.AreEqual(8, daily.Proceed(root2));
        }
    }
}