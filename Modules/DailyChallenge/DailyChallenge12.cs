using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge12
    {

        public string Proceed(string str, int k)
        {
            List<string> result = new List<string>();
            for(int i = 0; i< str.Length; ++i)
            {
                string subString = str.Substring(i);
                if (result.Any() && result.Select(x => x.Length).Max() >= subString.Length)
                {
                    break;
                }
                string strResult = ProceedIntern(subString, k);
                if (string.IsNullOrEmpty(strResult) == false)
                {
                    result.Add(strResult);
                }
            }
            return result.OrderByDescending(x => x.Length).FirstOrDefault();
        }

        private string ProceedIntern(string str, int k)
        {
            int left = k;
            HashSet<char> chars = new HashSet<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (chars.Add(ch))
                {
                    left--;
                    if (left < 0)
                    {
                        break;
                    }
                }
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
