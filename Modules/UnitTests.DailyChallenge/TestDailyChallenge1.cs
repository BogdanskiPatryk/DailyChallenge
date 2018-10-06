using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge1;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge1
    {
        [TestMethod]
        public void DailyChallenge1()
        {
            Node node = new Node
            {
                Value = "Root",
                Left = new Node
                {
                    Value = "Left",
                    Left = new Node
                    {
                        Value = "Left.Left"
                    },
                    Right = new Node
                    {
                        Value = "Left.Right"
                    }
                },
                Right = new Node { Value = "Right" }
            };
            DailyChallenge1 serializer = new DailyChallenge1();
            string data = serializer.Serialize(node);
            Node result = serializer.Deserialize(data);
            Assert.AreEqual("Left.Left", result.Left.Left.Value);
        }
    }
}