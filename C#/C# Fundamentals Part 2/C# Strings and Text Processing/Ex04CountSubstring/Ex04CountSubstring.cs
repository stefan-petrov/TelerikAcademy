using System;
using System.Collections.Generic;
using System.IO;


//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

namespace Ex04CountSubstring
{
    class Ex04CountSubstring
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../textfile.txt");
            using (reader)
            {
                string text = reader.ReadToEnd().ToLower();
                int counter = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    int index = text.IndexOf("in", i);
                    if (index != -1)
                    {
                        counter++;
                        i = index;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}
