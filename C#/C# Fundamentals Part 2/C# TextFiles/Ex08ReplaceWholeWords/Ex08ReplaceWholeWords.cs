using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Modify the solution of the previous problem to replace only whole words (not substrings).

namespace Ex08ReplaceWholeWords
{
    class Ex08ReplaceWholeWords
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");

            using (reader)
            {
                using (writer)
                {
                    string currentLine = reader.ReadLine();
                    string replacedString = "";
                    while (currentLine != null)
                    {
                        replacedString = Regex.Replace(currentLine, @"\bsherlock\b", "Ivan", RegexOptions.IgnoreCase);
                        replacedString = Regex.Replace(replacedString, @"\bholmes\b", "Ivanov", RegexOptions.IgnoreCase);
                        replacedString = Regex.Replace(replacedString, @"\bwatson\b", "Pesho", RegexOptions.IgnoreCase);
                        writer.WriteLine(replacedString);
                        writer.Flush();
                        currentLine = reader.ReadLine();
                    }
                }
            }

            // File.Replace(@"../../result.txt", @"../../textfile.txt", "backup.txt");
        }
    }
}
