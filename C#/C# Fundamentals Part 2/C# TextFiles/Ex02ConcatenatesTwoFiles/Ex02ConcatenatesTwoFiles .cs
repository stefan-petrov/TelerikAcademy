using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that concatenates two text files into another text file.

namespace Ex02ConcatenatesTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader(@"../../textfile1.txt");
            StreamReader reader2 = new StreamReader(@"../../textfile2.txt");
            StreamWriter writer = new StreamWriter(@"../../textfile3.txt");

            using (reader1)
            {

                using (reader2)
                {

                    string stringTextfile1 = reader1.ReadLine();
                    string stringTextfile2 = reader2.ReadLine();
                    using (writer)
                    {
                        while (stringTextfile1 != null || stringTextfile2 != null)
                        {

                            writer.WriteLine(string.Concat(stringTextfile1, stringTextfile2));

                            stringTextfile1 = reader1.ReadLine();
                            stringTextfile2 = reader2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
