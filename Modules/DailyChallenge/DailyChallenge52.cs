using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    /*
     * Implement a queue using two stacks. Recall that a queue is a FIFO (first-in, first-out) data structure with the following methods: enqueue, which inserts an element into the queue, and dequeue, which removes it.
     */
    public class DailyChallenge52
    {
        private Stack<int> _first = new Stack<int>();
        private Stack<int> _second = new Stack<int>();

        public void Enqueue(int value)
        {
            _first.Push(value);
        }

        public int Dequeue()
        {
            if (_first.Any() == false)
            {
                throw new ArgumentOutOfRangeException();
            }
            while(_first.Any())
            {
                _second.Push(_first.Pop());
            }
            int result = _second.Pop();
            while(_second.Any())
            {
                _first.Push(_second.Pop());
            }
            return result;
        }
    }
}
