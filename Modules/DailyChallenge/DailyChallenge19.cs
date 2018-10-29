using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge19
    {
        /*
         * Given two singly linked lists that intersect at some point, find the intersecting node. The lists are non-cyclical.
For example, given A = 3 -> 7 -> 8 -> 10 and B = 99 -> 1 -> 8 -> 10, return the node with value 8.
In this example, assume nodes with the same value are the exact same node objects.
Do this in O(M + N) time (where M and N are the lengths of the lists) and constant space.
         */

        public class Element
        {
            public Guid ID { get; private set; }
            public int Value { get; private set; }

            public Element(int value)
            {
                Value = value;
                ID = Guid.NewGuid();
            }
        }

        public Element Proceed(LinkedList<Element> first, LinkedList<Element> second)
        {
            int diff = Math.Abs(first.Count - second.Count);
            LinkedList<Element> shortest = first.Count < second.Count ? first : second;
            LinkedList<Element> longest = first.Count >= second.Count ? first : second;
            LinkedListNode<Element> elementShort = shortest.First;
            LinkedListNode<Element> elementLongest = longest.First;
            for (int i = 0; i < longest.Count - shortest.Count; i++)
            {
                elementLongest = elementLongest.Next;
            }
            Element match = null;
            while (elementShort != null)
            {
                if (elementShort.Value.ID == elementLongest.Value.ID)
                {
                    if (match == null)
                    {
                        match = elementLongest.Value;
                    }
                }
                else
                {
                    match = null;
                }
                elementShort = elementShort.Next;
                elementLongest = elementLongest.Next;
            }
            return match;
        }
    }
}
