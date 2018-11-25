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
                secondLargest = current.Left;
                return ProceedIntern(current.Left, secondLargest);
            }
            return secondLargest;
        }
    }
}
