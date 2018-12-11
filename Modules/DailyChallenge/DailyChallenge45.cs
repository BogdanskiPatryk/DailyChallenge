using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge45
    {
        /*
         * Given a string, find the longest palindromic contiguous substring. If there are more than one with the maximum length, return any one.
For example, the longest palindromic substring of "aabcdcb" is "bcdcb". The longest palindromic substring of "bananas" is "anana".
         */

        public string Proceed(string text)
        {
            if (IsPalindrom(text))
            {
                return text;
            }
            return ProceedIntern(text, null);
        }

        private string ProceedIntern(string text, bool? onRight)
        {
            if (text.Length <= 1)
            {
                return text;
            }
            string strLeft = text.Substring(0, text.Length - 1);
            if (IsPalindrom(strLeft))
            {
                return strLeft;
            }
            string strRight = text.Substring(1, text.Length - 1);
            if (IsPalindrom(strRight))
            {
                return strRight;
            }
            string rightPalindrom = string.Empty;
            string leftPalindrom = string.Empty;
            if (onRight.HasValue == false || onRight.Value)
            {
                rightPalindrom = ProceedIntern(strRight, true);
            }
            if (onRight.HasValue == false || onRight.Value == false)
            {
                leftPalindrom = ProceedIntern(strLeft, false);
            }
            return leftPalindrom.Length > rightPalindrom.Length ? leftPalindrom : rightPalindrom;
        }

        private bool IsPalindrom(string text)
        {
            int l = 0;
            int h = text.Length - 1;
            while (text[l] == text[h])
            {
                if (l >= h)
                {
                    // palindrom
                    return true;
                }
                l++;
                h--;
            }
            return false;
        }
    }
}
