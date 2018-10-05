using System;
using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge0
    {
        /*
         * For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
         */

        [TestMethod]
        public void DailyChallenge_0()
        {
            DailyChallenge0 dc = new DailyChallenge0();
            int[] inputA = new int[] { 1, 2, 3, 4, 5 };
            int[] inputB = new int[] { 3, 2, 1 };
            int[] inputC = new int[] { 3, 2, 0 };
            int[] outputA = dc.Proceed(inputA);
            int[] outputB = dc.Proceed(inputB);
            int[] outputC = dc.Proceed(inputC);
            Test(new int[] { 120, 60, 40, 30, 24 }, outputA);
            Test(new int[] { 2, 3, 6 }, outputB);
            Test(new int[] { 0, 0, 6 }, outputC);
        }

        private void Test(int[] tableA, int[] tableB)
        {
            Assert.AreEqual(tableA.Length, tableB.Length);
            for (int i = 0; i < tableA.Length; ++i)
            {
                Assert.AreEqual(tableA[i], tableB[i]);
            }
        }
    }
}