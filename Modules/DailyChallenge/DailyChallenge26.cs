using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge26
    {
        /*
         * iven a string of round, curly, and square open and closing brackets, return whether the brackets are balanced (well-formed).
For example, given the string "([])[]({})", you should return true.
Given the string "([)]" or "((()", you should return false.
         */
         
        private class OpenClose
        {
            public char Open;
            public char Close;
        }

        private List<OpenClose> _openClose = new List<OpenClose>()
        {
            new OpenClose{Open = '{', Close = '}'},
            new OpenClose{Open = '[', Close = ']'},
            new OpenClose{Open = '(', Close = ')'},
        };

        public bool Proceed(string text)
        {
            Stack<char> queue = new Stack<char>();
            foreach(var ch in text)
            {
                OpenClose open = _openClose.FirstOrDefault(x => x.Open == ch);
                OpenClose close = _openClose.FirstOrDefault(x => x.Close == ch);
                if (open == null && close == null)
                {
                    return false;
                }
                if (open != null)
                {
                    queue.Push(open.Open);
                }
                else
                {
                    if (queue.Any() == false)
                    {
                        return false;
                    }
                    char poped = queue.Pop();
                    if (poped != close.Open)
                    {
                        return false;
                    }
                }
            }
            return queue.Any() == false;
        }
    }
}
