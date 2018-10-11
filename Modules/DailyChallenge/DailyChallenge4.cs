using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge4
    {
        /*
         * cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns the first and last element of that pair. For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
Given this implementation of cons:
def cons(a, b):
    def pair(f):
        return f(a, b)
    return pair
Implement car and cdr.
         */

        public Tuple<int, int> Cons(int a, int b)
        {
            return new Tuple<int, int>(a, b);
        }

        public int Car(Tuple<int, int> pair)
        {
            return pair.Item1;
        }

        public int Cdr(Tuple<int, int> pair)
        {
            return pair.Item2;
        }
    }
}