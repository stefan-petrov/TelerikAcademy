using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a list of words from a file words.txt and finds how many times
// each of the words is contained in another file test.txt. The result should be written
// in the file result.txt and the words should be sorted by the number of their occurrences 
// in descending order. Handle all possible exceptions in your methods.

namespace Ex13CountWords
{
    class Ex13CountWords
    {
        static void Main(string[] args)
        {
            StreamReader readerTextFile = new StreamReader(@"../../test.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");
            StreamReader readerWordsToCount = new StreamReader(@"../../words.txt");
            string wordToCount = readerWordsToCount.ReadLine();
            string text = readerTextFile.ReadToEnd();
            int count = 0;
            List<string> tmpList = new List<string>();

            using (readerTextFile)
            {
                using (writer)
                {
                    while (wordToCount != null)
                    {
                        count = CountWord(wordToCount, text); 
                        tmpList.Add(count + " " + wordToCount);
                        wordToCount = readerWordsToCount.ReadLine();  
                    
                    }
                    
                    tmpList.Sort();
                    tmpList.Reverse();
                    
                    for (int i = 0; i < tmpList.Count; i++)
                    {
                        string currentWord = tmpList[i];
                        int wordIndex = currentWord.IndexOf(" ");
                        currentWord = currentWord.Remove(0, wordIndex + 1);
                        tmpList[i] = currentWord;
                    }

                    foreach (string str in tmpList)
                    {
                        writer.WriteLine(str);
                    }
                }
            }

        }

        public static int CountWord(string wordToCount, string text)
        {
            int wordIndex = text.IndexOf(wordToCount);
            int count = 0;
            
            while (wordIndex != -1)
            {
                count++;
                wordIndex = text.IndexOf(wordToCount, wordIndex + 1);
            }
            return count;
        }
    }
}
