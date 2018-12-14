using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge50
    {
        /*
         * Given a function that generates perfectly random numbers between 1 and k (inclusive), where k is an input, write a function that shuffles a deck of cards represented as an array using only swaps.
It should run in O(N) time.
Hint: Make sure each one of the 52! permutations of the deck is equally likely.
         */

        public void Proceed(int[] cards)
        {
            for(int i= 0; i < cards.Length; ++i)
            {
                int index = PerfectRandom(cards.Length - 1);
                int card = cards[index];
                cards[index] = cards[0];
                cards[0] = card;
            }
        }

        private int PerfectRandom(int k)
        {
            Random random = new Random();
            return random.Next(0, k) + 1;
        }
    }
}
