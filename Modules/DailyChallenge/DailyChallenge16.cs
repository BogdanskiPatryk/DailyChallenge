using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge16
    {
        /*
         * Suppose we represent our file system by a string in the following manner:
The string "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext" represents:
dir
    subdir1
    subdir2
        file.ext
The directory dir contains an empty sub-directory subdir1 and a sub-directory subdir2 containing a file file.ext.
The string "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext" represents:
dir
    subdir1
        file1.ext
        subsubdir1
    subdir2
        subsubdir2
            file2.ext
The directory dir contains two sub-directories subdir1 and subdir2. subdir1 contains a file file1.ext and an empty second-level sub-directory subsubdir1. subdir2 contains a second-level sub-directory subsubdir2 containing a file file2.ext.
We are interested in finding the longest (number of characters) absolute path to a file within our file system. For example, in the second example above, the longest absolute path is "dir/subdir2/subsubdir2/file2.ext", and its length is 32 (not including the double quotes).
Given a string representing the file system in the above format, return the length of the longest absolute path to a file in the abstracted file system. If there is no file in the system, return 0.
Note:
The name of a file contains at least a period and an extension.
The name of a directory or sub-directory will not contain a period.

         */

        public int Proceed(string strPath)
        {
            if (string.IsNullOrWhiteSpace(strPath))
            {
                return 0;
            }
            // spearate for lines
            IEnumerable<string> lines = strPath.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            IEnumerable<string> paths = GetFilePaths(lines);
            if (paths.Any() == false)
            {
                return 0;
            }
            return paths.OrderByDescending(x => x.Length).First().Length;
        }

        private List<string> GetFilePaths(IEnumerable<string> lines)
        {
            List<string> files = new List<string>();
            LinkedList<string> currentPath = new LinkedList<string>();

            int currentLevel = -1;
            foreach(string line in lines)
            {
                int level = Regex.Matches(line, "\t").Count;
                string formatedLine = line.Substring(level);
                // Prepare levels
                if (level <= currentLevel)
                {
                    for (int i = currentLevel; i >= level; --i)
                    {
                        if (currentPath.Any())
                        {
                            currentPath.RemoveLast();
                        }
                    }
                    currentLevel = level;
                }
                // Add file or folder
                if (formatedLine.Contains('.') == false)
                {
                    currentLevel = level;
                    currentPath.AddLast(formatedLine);
                }
                else
                {
                    string file = string.Join(@"/", currentPath.ToArray());
                    file += $@"/{formatedLine}";
                    files.Add(file);
                }
            }
            return files;
        }
    }
}
