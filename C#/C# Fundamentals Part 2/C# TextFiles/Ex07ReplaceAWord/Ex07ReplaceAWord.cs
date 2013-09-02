using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Write a program that replaces all occurrences of the substring "start" with the substring 
// "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

namespace Ex07ReplaceAWord
{
    class Ex07ReplaceAWord
    {
        // This program replaces all names in given file. Example: Sherlock Holmes -> Ivan Ivanov, Watson -> Pesho
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
                        replacedString = Regex.Replace(currentLine, "sherlock", "Ivan", RegexOptions.IgnoreCase);
                        replacedString = Regex.Replace(replacedString, "holmes", "Ivanov", RegexOptions.IgnoreCase);
                        replacedString = Regex.Replace(replacedString, "watson", "Pesho", RegexOptions.IgnoreCase);
                        writer.WriteLine(replacedString);
                        writer.Flush();
                        currentLine = reader.ReadLine();
                    }
                }
            }         
        }
    }
}
