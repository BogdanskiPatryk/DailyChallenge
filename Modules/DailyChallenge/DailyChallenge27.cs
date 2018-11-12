using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge27
    {
        /*
         * Write an algorithm to justify text. Given a sequence of words and an integer line length k, return a list of strings which represents each line, fully justified.
More specifically, you should have as many words as possible in each line. There should be at least one space between each word. Pad extra spaces when necessary so that each line has exactly length k. Spaces should be distributed as equally as possible, with the extra spaces, if any, distributed starting from the left.
If you can only fit one word on a line, then you should pad the right-hand side with spaces.
Each word is guaranteed not to be longer than k.
For example, given the list of words ["the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"] and k = 16, you should return the following:
["the  quick brown", # 1 extra space on the left
"fox  jumps  over", # 2 extra spaces distributed evenly
"the   lazy   dog"] # 4 extra spaces distributed evenly

         */

        private class Word
        {
            public string Text;
            public bool IsSpace;
        }

        private class Line
        {
            public List<Word> Words = new List<Word>();
            public int Length => Words.Sum(x => x.Text.Length);
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (var word in Words)
                {
                    sb.Append(word.Text);
                }
                return sb.ToString();
            }
        }

        public string[] Proceed(IEnumerable<string> words, int length)
        {
            List<string> lines = new List<string>();
            Line currentLine = new Line();
            foreach (string word in words.Select(x => x.Trim()))
            {
                if (currentLine.Length == 0)
                {
                    currentLine.Words.Add(new Word() { Text = word, IsSpace = false });
                    continue;
                }
                if (currentLine.Length + word.Length >= length)
                {
                    // Cannot Add. Justify
                    Justify(currentLine, length);
                    lines.Add(currentLine.ToString());
                    currentLine = new Line();
                    currentLine.Words.Add(new Word() { Text = word, IsSpace = false });
                    continue;
                }
                currentLine.Words.Add(new Word() { Text = " ", IsSpace = true });
                currentLine.Words.Add(new Word() { Text = word, IsSpace = false });
            }
            if (currentLine.Length != 0)
            {
                Justify(currentLine, length);
                lines.Add(currentLine.ToString());
            }
            return lines.ToArray();
        }

        private void Justify(Line line, int length)
        {
            if (line.Words.Count == 1)
            {
                line.Words.Add(new Word { Text = new string(' ', length - line.Words[0].Text.Length), IsSpace = true });
                return;
            }
            int spaces = line.Words.Count(x => x.IsSpace);
            int lastSpaceIndex = 0;
            for (int leftSpaces = length - line.Length; leftSpaces > 0; --leftSpaces)
            {
                if (lastSpaceIndex >= spaces)
                {
                    lastSpaceIndex = 0;
                }
                Word word = line.Words.Where(x => x.IsSpace).Skip(lastSpaceIndex).First();
                word.Text += " ";
                lastSpaceIndex++;
            }
        }
    }
}
