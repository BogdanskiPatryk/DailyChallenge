using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge28
    {
        /*
         * Run-length encoding is a fast and simple method of encoding strings. The basic idea is to represent repeated successive characters as a single count and character. For example, the string "AAAABBBCCDAA" would be encoded as "4A3B2C1D2A".
Implement run-length encoding and decoding. You can assume the string to be encoded have no digits and consists solely of alphabetic characters. You can assume the string to be decoded is valid.
         */
         

        public string Encode(string text)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 1;
            char currentChar = text[0];
            foreach(char ch in text.Skip(1))
            {
                if (currentChar == ch)
                {
                    counter++;
                    continue;
                }
                sb.Append($"{counter}{currentChar}");
                counter = 1;
                currentChar = ch;
            }
            sb.Append($"{counter}{currentChar}");
            return sb.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< text.Length; i +=2)
            {
                int number = int.Parse(text[i].ToString());
                char ch = text[i + 1];
                sb.Append(new string(ch, number));

            }
            return sb.ToString();
        }
    }
}
