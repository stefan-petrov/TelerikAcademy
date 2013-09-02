using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that removes from a text file all words listed in given another text file. 
// Handle all possible exceptions in your methods.

namespace Ex12RemoveWords
{
    class Ex12RemoveWords
    {
        
        static string RemoveWord(string wordToRemove, string text)
        {           
            int wordLenght = wordToRemove.Length;
            int wordIndex = text.IndexOf(wordToRemove);

            while (wordIndex != -1)
            {
                text = text.Remove(wordIndex, wordLenght);
                wordIndex = text.IndexOf(wordToRemove);
            }

            return text;
        }

        static void Main(string[] args)
        {
            StreamReader readerTextFile = new StreamReader(@"../../textfile.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");           
            StreamReader readerWordsToRemove = new StreamReader(@"../../wordstoremove.txt");
            string wordToRemove = readerWordsToRemove.ReadLine();
            string text = readerTextFile.ReadToEnd();
            
            using (readerTextFile)
            {
                using (writer)
                {
                    while (wordToRemove != null)
                    {
                        text = RemoveWord(wordToRemove , text);
                        wordToRemove = readerWordsToRemove.ReadLine();                     
                    }   
                    writer.Write(text);
                }
            }
            
        }
    }
}
