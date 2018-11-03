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
    public class TestDailyChallenge21
    {
        [TestMethod]
        public void DailyChallenge21()
        {
            DailyChallenge21 daily = new DailyChallenge21();
            string[] result = daily.Proceed("thequickbrownfox", new string[] { "quick", "brown", "the", "fox" });
            Assert.IsTrue(IsEqual(new string[] { "the", "quick", "brown", "fox" }, result));
            result = daily.Proceed("bedbathandbeyond", new string[] { "bed", "bath", "bedbath", "and", "beyond" });
            Assert.IsTrue(IsAnyEqual(new List<string[]>
            {
                new string[] { "bed", "bath", "and", "beyond" },
                new string[] { "bedbath", "and", "beyond" }
            }, result));
        }

        private bool IsEqual(string[] expected, string[] current)
        {
            if (expected.Length != current.Length)
            {
                return false;
            }
            for(int i = 0; i< expected.Length;++i)
            {
                if (expected[i] != current[i])
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsAnyEqual(IEnumerable<string[]> expected, string[] current)
        {
            foreach(var e in expected)
            {
                if (IsEqual(e, current))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
