using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge33
    {
        /*
         * Given a string, find the palindrome that can be made by inserting the fewest number of characters as possible anywhere in the word. If there is more than one palindrome of minimum length that can be made, return the lexicographically earliest one (the first one alphabetically).
For example, given the string "race", you should return "ecarace", since we can add three letters to it (which is the smallest amount to make a palindrome). There are seven other palindromes that can be made from "race" by adding three letters, but "ecarace" comes first alphabetically.
As another example, given the string "google", you should return "elgoogle".
         */
         


        public string Proceed(string text)
        {
            List<string> results = ProceedIntern(text).ToList();
            return results.GroupBy(x => x.Length).OrderBy(x => x.Key).FirstOrDefault()?.OrderBy(x => x).FirstOrDefault();
        }

        private IEnumerable<string> ProceedIntern(string text)
        {
            if (text.Length == 1 || text.Length == 0)
            {
                return new[] { text };
            }
            int l = 0;
            int h = text.Length - 1;
            while (text[l] == text[h])
            {
                if (l >= h)
                {
                    // palindrom
                    return new[] { text };
                }
                l++;
                h--;
            }
            List<string> result = new List<string>();
            string formatedText = text.Substring(l, text.Length - l * 2);
            foreach (var res in ProceedIntern(formatedText.Last() + formatedText))
            {
                result.Add(text.Substring(0, l) + res + text.Substring(h+1));
            }
            foreach(var res in ProceedIntern(formatedText + formatedText.First()))
            {
                result.Add(text.Substring(0, l) + res + text.Substring(h+1));
            }
            return result;
        }
        
    }
}
