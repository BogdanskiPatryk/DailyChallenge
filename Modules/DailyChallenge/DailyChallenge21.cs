using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge21
    {
        /*
         * Given a dictionary of words and a string made up of those words (no spaces), return the original sentence in a list. If there is more than one possible reconstruction, return any of them. If there is no possible reconstruction, then return null.
For example, given the set of words 'quick', 'brown', 'the', 'fox', and the string "thequickbrownfox", you should return ['the', 'quick', 'brown', 'fox'].
Given the set of words 'bed', 'bath', 'bedbath', 'and', 'beyond', and the string "bedbathandbeyond", return either ['bed', 'bath', 'and', 'beyond] or ['bedbath', 'and', 'beyond'].
         * 
         */

        public string[] Proceed(string strText, IEnumerable<string> set)
        {
            LinkedList<string> result = new LinkedList<string>();
            if (ProceedIntern(strText, set.ToList(), result))
            {
                return result.ToArray();
            }
            return null;
        }

        private bool ProceedIntern(string strText, List<string> leftWords, LinkedList<string> result)
        {
            if (strText.Length == 0)
            {
                return true;
            }
            foreach(string word in leftWords)
            {
                if (strText.StartsWith(word))
                {
                    result.AddLast(word);
                    if (ProceedIntern(strText.Substring(word.Length), leftWords.Except(new string[] { word}).ToList(), result))
                    {
                        return true;
                    }
                    result.RemoveLast();
                }
            }
            return false;
        }
    }
}
