using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise7
{
    class Program
    {
        // This program replaces all names in given file. Example: Sherlock Holmes -> Ivan Ivanov, Watson -> Pesho
        static void Main(string[] args)
        {       
            StreamReader reader = new StreamReader(@"../../textfile.txt" );
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
            
            File.Replace(@"../../result.txt", @"../../textfile.txt", @"../../backup.txt");
        }
    }
}
