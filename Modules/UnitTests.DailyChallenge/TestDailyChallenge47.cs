using DailyChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyChallenge.DailyChallenge47;

namespace UnitTests.DailyChallenge
{
    [TestClass]
    public class TestDailyChallenge47
    {
        /*
         * [a, b, d, e, c, f, g]
And the following inorder traversal:
[d, b, e, a, f, c, g]
You should return the following tree:
    a
   / \
  b   c
 / \ / \
d  e f  g

         */

        [TestMethod]
        public void DailyChallenge47()
        {
            DailyChallenge47 daily = new DailyChallenge47();
            Node root = daily.Proceed(new char[] { 'a', 'b', 'd', 'e', 'c', 'f', 'g' }, new char[] { 'd', 'b', 'e', 'a', 'f', 'c', 'g' });
            Assert.IsNotNull(root);
            Assert.AreEqual('a', root.Value);

            Assert.IsNotNull(root.Left);
            Assert.AreEqual('b', root.Left.Value);

            Assert.IsNotNull(root.Right);
            Assert.AreEqual('c', root.Right.Value);

            Assert.IsNotNull(root.Left.Left);
            Assert.AreEqual('d', root.Left.Left.Value);

            Assert.IsNotNull(root.Left.Right);
            Assert.AreEqual('e', root.Left.Right.Value);

            Assert.IsNotNull(root.Right.Left);
            Assert.AreEqual('f', root.Right.Left.Value);

            Assert.IsNotNull(root.Right.Right);
            Assert.AreEqual('g', root.Right.Right.Value);
        }
    }
}
