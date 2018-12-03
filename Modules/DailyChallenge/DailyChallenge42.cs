using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge42
    {
        /*
         * Implement a stack that has the following methods:
•	push(val), which pushes an element onto the stack
•	pop(), which pops off and returns the topmost element of the stack. If there are no elements in the stack, then it should throw an error or return null.
•	max(), which returns the maximum value in the stack currently. If there are no elements in the stack, then it should throw an error or return null.
Each method should run in constant time.
         */


        private class Element
        {
            public int Value;
            public int Max;
        }

        private LinkedList<Element> _elements = new LinkedList<Element>();

        public void Push(int value)
        {
            if (_elements.Count == 0)
            {
                _elements.AddLast(new Element() { Value = value, Max = value });
            }
            else
            {
                _elements.AddLast(new Element() { Value = value, Max = Math.Max(value, _elements.Last.Value.Max) }); 
            }
        }

        public int Pop()
        {
            if(_elements.Last == null)
            {
                throw new ArgumentNullException();
            }
            Element element = _elements.Last.Value;
            _elements.RemoveLast();
            return element.Value;
        }

        public int Max()
        {
            if (_elements.Last == null)
            {
                throw new ArgumentNullException();
            }
            return _elements.Last.Value.Max;
        }
    }
}
