using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge21
    {
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
