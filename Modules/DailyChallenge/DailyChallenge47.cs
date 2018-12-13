using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge47
    {
        /*
         * Given pre-order and in-order traversals of a binary tree, write a function to reconstruct the tree.
For example, given the following preorder traversal:
[a, b, d, e, c, f, g]
And the following inorder traversal:
[d, b, e, a, f, c, g]
You should return the following tree:
    a
   / \
  b   c
 / \ / \
d  e f  g
         */

        public class Node
        {
            public Node Left;
            public Node Right;
            public char Value;
        }

        public Node Proceed(char[] preorder, char[] inorder)
        {
            if (preorder.Length != inorder.Length)
            {
                throw new ArgumentException();
            }
            Node root = new Node();
            if(ProceedIntern(root, preorder.ToList(), inorder.ToList()))
            {
                return root;
            }
            return null;
        }

        public bool ProceedIntern(Node current, List<char> preorder, List<char> inorder)
        {
            if (inorder.Any() == false)
            {
                return false;
            }
            current.Value = preorder[0];
            if (inorder.Count == 2)
            {
                current.Left = new Node() { Value = preorder[1] };
            }
            else if (inorder.Count == 3)
            {
                current.Left = new Node() { Value = preorder[1] };
                current.Right = new Node() { Value = preorder[2] };
            }
            else
            {
                int index = inorder.IndexOf(current.Value);
                if (index < 0)
                {
                    throw new InvalidOperationException();
                }
                Node left = new Node();
                if (ProceedIntern(left, preorder.Skip(1).ToList(), inorder.Take(index).ToList()))
                {
                    current.Left = left;
                }
                Node right = new Node();
                if (ProceedIntern(right, preorder.Skip(index + 1).ToList(), inorder.Skip(index + 1).ToList()))
                {
                    current.Right = right;
                }
            }
            return true;
        }
    }
}
