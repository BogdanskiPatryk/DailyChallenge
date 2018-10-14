using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge6
    {
        /*
Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
You can assume that the messages are decodable. For example, '001' is not allowed.
         */

        public int Proceed(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }
            return ProceedInternal(text);
        }

        private int ProceedInternal(string text)
        {
            if (text.Length < 3)
            {
                return ProceedOneOrTwoChars(text);
            }
            // At least 3
            int parsedOne = int.Parse(text[0].ToString());
            int parsedTwo = int.Parse(string.Concat(text.Take(2)));
            int result = 0;
            if (InRange(parsedOne))
            {
                result += ProceedInternal(string.Concat(text.Skip(1)));
            }
            if (InRange(parsedTwo))
            {
                result += ProceedInternal(string.Concat(text.Skip(2)));
            }
            return result;
        }

        private int ProceedOneOrTwoChars(string text)
        {
            if (text.Length == 1)
            {
                int parsed = int.Parse(text);
                return InRange(parsed) ? 1 : 0;
            }
            int parsedTwo = int.Parse(text);
            int result = InRange(parsedTwo) ? 1 : 0;
            // Add "twoChar" to "two separate chars" (if one is not parseable then 0)
            return result + ProceedOneOrTwoChars(string.Concat(text[0])) * ProceedOneOrTwoChars(string.Concat(text[1]));
        }

        private bool InRange(int number)
        {
            return number > 0 && number <= 26;
        }
    }
}