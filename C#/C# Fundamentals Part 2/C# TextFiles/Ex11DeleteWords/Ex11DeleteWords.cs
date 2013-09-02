using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex11DeleteWords
{
    class Ex11DeleteWords
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    string pattern = "test.[A-Za-z0-9_]*";

                    while (line != null)
                    {
                        Match match = Regex.Match(line, pattern, RegexOptions.IgnoreCase);
                        int indexOfFound = line.IndexOf(match.Value.ToString());
                        int foundStringLenght = match.Length;
                        line = line.Remove(indexOfFound, foundStringLenght);
                        writer.WriteLine(line);
                        line = reader.ReadLine();

                    }

                }
            }
            //File.Replace(@"../../result.txt", @"../../textfile.txt", @"../../backupfile.txt");
        }
    }
}
