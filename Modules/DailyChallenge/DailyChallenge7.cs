using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge7
    {
        /*
         *
         * A unival tree (which stands for "universal value") is a tree where all nodes under it have the same value.
Given the root to a binary tree, count the number of unival subtrees.
For example, the following tree has 5 unival subtrees:
   0
  / \
 1   0
    / \
   1   0
  / \
 1   1

         */

        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        public int Proceed(Node treeRoot)
        {
            return ProceedIntern(treeRoot, null, 1);
        }

        private int ProceedIntern(Node node, Node parent, int multipler)
        {
            int result = 0;
            if (node == null)
            {
                return result;
            }
            int newMultipler = 1;
            if (parent != null && parent.Value == node.Value)
            {
                result += multipler;
                newMultipler = multipler + 1;
            }
            result += ProceedIntern(node.Left, node, newMultipler);
            result += ProceedIntern(node.Right, node, newMultipler);
            return result;
        }
    }
}