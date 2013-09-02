using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Write a program that extracts from given XML file all the text without the tags.

namespace Ex10ExtractFromXML
{
    class Ex10ExtractFromXML
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
                    string pattern = ">[^<]*</";

                    foreach (Match match in Regex.Matches(line, pattern, RegexOptions.IgnoreCase))
                    {
                        string tmpStr = match.Value.ToString();
                        char[] charsToTrim = new char[] { '<', '/', '>', ' ' };
                        tmpStr = tmpStr.Trim(charsToTrim);
                        if (tmpStr != "")
                        {
                            writer.WriteLine(tmpStr);
                        }
                    }


                }
            }
        }
    }
}
