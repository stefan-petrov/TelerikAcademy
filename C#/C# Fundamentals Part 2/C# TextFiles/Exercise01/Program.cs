using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader someReader = new StreamReader(@"../../textfile.txt");

            using (someReader)
            {
                int lineNum = 0;
                string lineText = someReader.ReadLine();

                while (lineText != null)
                {
                    lineNum++;
                    if (lineNum % 2 != 0)
                    {
                        Console.WriteLine(lineText);
                    }
                    lineText = someReader.ReadLine();
                }

            }
        }
    }
}
