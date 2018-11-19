using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge30
    {
        /*
         * The edit distance between two strings refers to the minimum number of character insertions, deletions, and substitutions required to change one string to the other. For example, the edit distance between “kitten” and “sitting” is three: substitute the “k” for “s”, substitute the “e” for “i”, and append a “g”.
Given two strings, compute the edit distance between them.

         */

        public int Proceed(string strA, string strB)
        {
            if (string.IsNullOrEmpty(strA) || string.IsNullOrEmpty(strB))
            {
                return Math.Max(strA?.Length ?? 0, strB?.Length ?? 0);
            }
            if (strA.Last() == strB.Last())
            {
                // We can ignore last characters
                return Proceed(RemoveLast(strA), RemoveLast(strB));
            }
            
            int insert = Proceed(strA, RemoveLast(strB));
            int remove = Proceed(RemoveLast(strA), strB);
            int replace = Proceed(RemoveLast(strA), RemoveLast(strB));
            return 1 + Math.Min(Math.Min(insert, remove), replace);
        }
        
        private string RemoveLast(string str)
        {
            return str.Substring(0, str.Length - 1);
        }
    
    }
}
