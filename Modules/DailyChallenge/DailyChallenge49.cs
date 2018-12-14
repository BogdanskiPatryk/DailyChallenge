using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge49
    {
        /*
         * Suppose an arithmetic expression is given as a binary tree. Each leaf is an integer and each internal node is one of '+', '−', '∗', or '/'.
Given the root to such a tree, write a function to evaluate it.
For example, given the following tree:
    *
   / \
  +    +
 / \  / \
3  2  4  5
You should return 45, as it is (3 + 2) * (4 + 5).
         */
         public class Node
        {
            public Node Left;
            public Node Right;
            public string Value;
        }

        public double Proceed(Node root)
        {
            if (string.IsNullOrWhiteSpace(root?.Value))
            {
                throw new ArgumentNullException();
            }
            if (double.TryParse(root.Value, out double value))
            {
                return value;
            }
            if (root.Value.Length > 1)
            {
                throw new ArgumentException();
            }
            char ch = root.Value[0];
            if (ch == '+')
            {
                return Proceed(root.Left) + Proceed(root.Right);
            }
            else if (ch == '-')
            {
                return Proceed(root.Left) - Proceed(root.Right);
            }
            else if (ch == '*')
            {
                return Proceed(root.Left) * Proceed(root.Right);
            }
            else if (ch == '/')
            {

                return Proceed(root.Left) / Proceed(root.Right);
            }
            throw new ArgumentException();
        }


    }
}
