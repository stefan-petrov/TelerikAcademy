using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. 

namespace Ex14Dictionary
{
    class Ex14Dictionary
    {
        static string ExtractExplanation(string str)
        {
            string extractedExplanation = "";
            StreamReader reader = new StreamReader("../../dictionaryData.txt");
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {

                    int index = currentLine.ToLower().IndexOf(str);
                    if (index == -1)
                    {
                        extractedExplanation = "Not Found";

                    }
                    else
                    {
                        extractedExplanation = currentLine.Remove(0, str.Length + 3);
                        return extractedExplanation;
                    }
                    currentLine = reader.ReadLine();
                }
                return extractedExplanation;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter word to be searched for: ");
                string input = Console.ReadLine();
                Console.WriteLine(ExtractExplanation(input.ToLower()));
                Console.WriteLine();
            }
        }
    }
}
