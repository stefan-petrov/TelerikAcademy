using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");
            StreamWriter writer = new StreamWriter(@"../../tempfile.txt");

            using (reader)
            {
                using (writer)
                {
                    int counter = 1;
                    string currentLine = reader.ReadLine();
                    while (currentLine != null)
                    {
                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(currentLine);
                        }
                        else
                        {
                            writer.WriteLine();
                        }
                        currentLine = reader.ReadLine();
                        counter++;
                    }

                }
            }
            File.Replace(@"../../tempfile.txt", @"../../textfile.txt", @"../../backup.txt");
        }
    }
}
