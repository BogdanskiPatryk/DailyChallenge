using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge25;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge25
    {
        [TestMethod]
        public void DailyChallenge25()
        {
            DailyChallenge25 daily = new DailyChallenge25();
            Node node400 = GenerateRandom(400);
            daily.Proceed(node400,100);
            int i = 0;
            while (node400 != null)
            {
                node400 = node400.Next;
                ++i;
            }
            Assert.AreEqual(300, i);
        }
        
        private Node GenerateRandom(int k)
        {
            Node first = null;
            Node last = null;
            for(int i=0;i<k;++i)
            {
                Node newNode = new Node();
                if (last != null)
                {
                    last.Next = newNode;
                }
                else
                {
                    first = newNode;
                }
                last = newNode;
            }
            return first;
        }
    }
}
