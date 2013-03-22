using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> foriddenWords = new List<string> { "Microsoft", "PHP", "CLR" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            for (int i = 0; i < foriddenWords.Count; i++)
            {
                string tempLowerCasedText = text.ToLower();
                int wordIndex = tempLowerCasedText.IndexOf(foriddenWords[i].ToLower());
                int lenght = foriddenWords[i].Length;
                
                while (wordIndex != -1)
                {

                    text = text.Remove(wordIndex, lenght);
                    text = text.Insert(wordIndex, new string('*', lenght));
                    wordIndex = text.IndexOf(foriddenWords[i]);
                }
            
            }
            Console.WriteLine(text);
        }
    }
}
