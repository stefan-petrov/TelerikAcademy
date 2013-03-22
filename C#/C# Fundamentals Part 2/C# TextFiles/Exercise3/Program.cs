using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
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
