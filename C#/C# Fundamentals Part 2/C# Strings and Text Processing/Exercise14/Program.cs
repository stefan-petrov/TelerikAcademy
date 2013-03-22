using System;
using System.IO;

namespace Exercise14
{
    class Program
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
            Console.WriteLine("Enter word to be searched for: ");
            string input = Console.ReadLine();
            Console.WriteLine(ExtractExplanation(input.ToLower()));
        }
    }
}
