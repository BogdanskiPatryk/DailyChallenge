using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge15
    {
        /*
         * You run an e-commerce website and want to record the last N order ids in a log. Implement a data structure to accomplish this, with the following API:
•	record(order_id): adds the order_id to the log
•	get_last(i): gets the ith last element from the log. i is guaranteed to be smaller than or equal to N.
You should be as efficient with time and space as possible.

         */


        public class Order
        {
            public Guid ID { get; set; }
        }

        LinkedList<Order> _orders = new LinkedList<Order>();
        private readonly int _limit;
        private int _records;

        public DailyChallenge15(int n)
        {
            _limit = n;
            _records = 0;
        }

        public void Record(Order order)
        {
            _records++;
            _orders.AddFirst(order);
            if (_records > _limit)
            {
                _orders.RemoveLast();
            }
        }

        public Order[] GetLast(int i)
        {
            return _orders.Take(i).ToArray();
        }
    }
}
