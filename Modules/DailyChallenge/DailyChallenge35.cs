using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge35
    {
        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;
        }

        public int Proceed(Node root)
        {
            return ProceedIntern(root, null)?.Value ?? -1;
        }

        private Node ProceedIntern(Node current, Node secondLargest)
        {
            if (current.Right != null)
            {
                secondLargest = current;
                return ProceedIntern(current.Right, secondLargest);
            }
            else if (current.Left != null)
            {
                return ProceedInternAfterLeftJump(current.Left, secondLargest);
            }
            return secondLargest;
        }

        private Node ProceedInternAfterLeftJump(Node current, Node secondLargest)
        {
            do
            {
                secondLargest = current;
                current = current.Right;
            }
            while (current != null);
            return secondLargest;
        }
    }
}
