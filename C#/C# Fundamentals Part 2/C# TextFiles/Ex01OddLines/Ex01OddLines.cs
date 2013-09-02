using System;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.

namespace Ex01OddLines
{
    class Ex01OddLines
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
