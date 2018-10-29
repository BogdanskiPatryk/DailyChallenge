using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge19;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge19
    {
        [TestMethod]
        public void DailyChallenge19()
        {
            DailyChallenge19 daily = new DailyChallenge19();
            Element[] common = new Element[]
            {
                new Element(8), new Element(10)
            };
            List<Element> first = new List<Element>()
            {
                new Element(3),
                new Element(7)
            };
            first.AddRange(common);
            List<Element> second = new List<Element>()
            {
                new Element(99), new Element(1)
            };
            second.AddRange(common);
            Assert.AreEqual(common[0], daily.Proceed(new LinkedList<Element>(first), new LinkedList<Element>(second)));

            common = new Element[]
            {
                new Element(7), new Element(8), new Element(10)
            };
            first = new List<Element>() { new Element(101), new Element(52), new Element(31), new Element(5), new Element(6) };
            second = new List<Element>() { new Element(53), new Element(42), new Element(2) };
            first.AddRange(common);
            second.AddRange(common);

            Assert.AreEqual(common[0], daily.Proceed(new LinkedList<Element>(first), new LinkedList<Element>(second)));


        }
    }
}
