using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Write a program that extracts from given HTML file its title (if available), 
// and its body text without the HTML tags. 

namespace Ex25ExtractTitleBodyFromHtml
{
    class Ex25ExtractTitleBodyFromHtml
    {
        static void Main(string[] args)
        {
            string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            int startIndex = 0;
            int index = str.IndexOf(">", startIndex);

            while (index != -1)
            {                
                string extractedText = ExtractText(str, index);
                if (extractedText != "" && extractedText != " ")
                {
                    Console.WriteLine(extractedText);
                }
                startIndex = index + 1;
                index = str.IndexOf(">", startIndex);
            }
        }

        public static string ExtractText(string text, int startIndex)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = startIndex + 1; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    break;                   
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }
    }
}
