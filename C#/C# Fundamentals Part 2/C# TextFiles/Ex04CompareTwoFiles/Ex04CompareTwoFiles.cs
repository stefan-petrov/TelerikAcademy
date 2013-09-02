using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two text files line by line and prints 
// the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

namespace Ex04CompareTwoFiles
{
    class Ex04CompareTwoFiles
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader(@"../../textfile1.txt");
            StreamReader reader2 = new StreamReader(@"../../textfile2.txt");
            int sameCounter = 0;
            int diffCounter = 0;

            using (reader1)
            {
                using (reader2)
                {
                    string stringTextfile1 = reader1.ReadLine();
                    string stringTextfile2 = reader2.ReadLine();


                    while (stringTextfile1 != null && stringTextfile2 != null)
                    {
                        if (stringTextfile1 == stringTextfile2)
                        {
                            sameCounter++;
                        }
                        else
                        {
                            diffCounter++;
                        }

                        stringTextfile1 = reader1.ReadLine();
                        stringTextfile2 = reader2.ReadLine();
                    }
                }
            }

            Console.WriteLine("The lines that are the same are exactly: {0}", sameCounter);
            Console.WriteLine("The lines that are different are exactly: {0}", diffCounter);
        }
    }
}
