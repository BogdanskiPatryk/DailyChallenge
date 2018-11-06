using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge23;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge23
    {
        [TestMethod]
        public void DailyChallenge23()
        {
            Node root = new Node();
            Node left_0 = new Node() { Parent = root };
            Node right_0 = new Node() { Parent = root };
            root.Left = left_0;
            root.Right = right_0;
            Node right_1_0 = new Node() { Parent = right_0 };
            Node right_1_1 = new Node() { Parent = right_0 };
            right_0.Left = right_1_0;
            right_0.Right = right_1_1;
            Node right_2_1 = new Node() { Parent = right_1_1 };
            right_1_1.Right = right_2_1;

            Assert.IsTrue(right_2_1.Lock());
            Assert.IsTrue(right_2_1.IsLocked());
            Assert.IsFalse(right_1_1.Lock());
            Assert.IsFalse(root.Lock());
            Assert.IsTrue(right_2_1.Unlock());

            Assert.IsTrue(left_0.Lock());
            Assert.IsTrue(right_2_1.Lock());
            Assert.IsFalse(root.Lock());
            Assert.IsTrue(left_0.Unlock());
            Assert.IsFalse(root.Lock());
            Assert.IsTrue(right_2_1.Unlock());
            Assert.IsTrue(root.Lock());
        }
    }
}
