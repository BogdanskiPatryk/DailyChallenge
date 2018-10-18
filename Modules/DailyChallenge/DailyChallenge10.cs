using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge10
    {
        private Dictionary<char, List<string>> _dictionary = new Dictionary<char, List<string>>();

        public DailyChallenge10(IEnumerable<string> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }
            foreach (string str in dictionary)
            {
                char firstChar = str[0];
                if (_dictionary.ContainsKey(firstChar) == false)
                {
                    _dictionary[firstChar] = new List<string>();
                }
                _dictionary[firstChar].Add(str.ToLower());
            }
            foreach (var value in _dictionary.Values)
            {
                value.Sort(StringComparer.OrdinalIgnoreCase);
            }
        }

        public IEnumerable<string> Proceed(string prefix)
        {
            if (string.IsNullOrWhiteSpace(prefix))
            {
                return new string[0];
            }
            if (_dictionary.TryGetValue(prefix[0], out List<string> sortedList) == false)
            {
                return new string[0];
            }
            bool bFound = false;
            List<string> result = new List<string>();
            foreach (string str in sortedList)
            {
                if (str.StartsWith(prefix))
                {
                    bFound = false;
                    result.Add(str);
                }
                else if (bFound)
                {
                    // It's sorted. Remember?
                    break;
                }
            }
            return result;
        }
    }
}
