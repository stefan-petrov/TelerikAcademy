using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a text file and inserts line numbers in front of 
// each of its lines. The result should be written to another text file.

namespace Ex03NumberTheLines
{
    class Ex03NumberTheLines
    {
        static void Main(string[] args)
        {
            StreamReader someReader = new StreamReader(@"../../textfile.txt");
            StreamWriter writer = new StreamWriter(@"../../numberedtextfile.txt");

            using (someReader)
            {
                using (writer)
                {
                    string line = someReader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        writer.WriteLine("Line ({0}): {1}", counter, line);
                        line = someReader.ReadLine();
                        counter++;
                    }
                }
            }

        }
    }
}
