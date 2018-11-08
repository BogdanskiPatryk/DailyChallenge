using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge25
    {
        /*
         * Given a singly linked list and an integer k, remove the kth last element from the list. k is guaranteed to be smaller than the length of the list.
The list is very long, so making more than one pass is prohibitively expensive.
Do this in constant space and in one pass.

         */
        public class Node
        {
            public Guid ID = Guid.NewGuid();
            public Node Next;
        }


        public void Proceed(Node first, int kLast)
        {
            Node node = first;
            Node remove = first;
            int k = 0;
            while (node != null)
            {
                if (k > kLast)
                {
                    remove = remove.Next;
                }
                k++;
                node = node.Next;
            }
            // GC will do the rest
            remove.Next = null;
        }
    }
}
