using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge24
    {
        /*
         * Implement regular expression matching with the following special characters:
•	. (period) which matches any single character
•	* (asterisk) which matches zero or more of the preceding element
That is, implement a function that takes in a string and a valid regular expression and returns whether or not the string matches the regular expression.
For example, given the regular expression "ra." and the string "ray", your function should return true. The same regular expression on the string "raymond" should return false.
Given the regular expression ".*at" and the string "chat", your function should return true. The same regular expression on the string "chats" should return false.

         */


        public bool Proceed(string text, string regex)
        {
            return ProceedIntern(text, regex);
        }

        private bool ProceedIntern(string text, string regex)
        {
            if (regex.Length == 0)
            {
                return text.Length == 0;
            }
            if (regex.First() == '.')
            {
                return ProceedIntern(text.Substring(1), regex.Substring(1));
            }

            if (regex.First() == '*')
            {
                if (regex.Length == 1)
                {
                    return true;
                }
                int nextSpecial = regex.IndexOfAny(new char[] { '.', '*' },1);
                if (nextSpecial < 0)
                {
                    return text.EndsWith(regex.Substring(1));
                }
                if (nextSpecial == 1)
                {
                    int nextDot = regex.IndexOf('.');
                    if (nextDot == nextSpecial)
                    {
                        if (text.Length == 0)
                        {
                            return false;
                        }
                        // *. => * (with skip one)
                        return ProceedIntern(text.Substring(1), "*" + regex.Substring(2));
                    }
                    else
                    {
                        // ** => *
                        return ProceedIntern(text, regex.Substring(1));
                    }
                }
                int inText = text.IndexOf(regex.Substring(1, nextSpecial - 1));
                if (inText < 0)
                {
                    return false;
                }
                return ProceedIntern(text.Substring(inText), regex.Substring(1, nextSpecial - 1));
            }
            else
            {
                int nextSpecial = regex.IndexOfAny(new char[] { '.', '*' });
                if (nextSpecial < 0)
                {
                    return text == regex;
                }
                if (text.StartsWith(regex.Substring(0, nextSpecial)))
                {
                    return ProceedIntern(text.Substring(nextSpecial), regex.Substring(nextSpecial));
                }
                return false;
            }
        }
    }
}
