using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string from the console and lists all different 
// words in the string along with information how many times each word is found.

namespace Ex22PrintWordCount
{
    class Ex22PrintWordCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string to count all the words in it: ");
            string input = Console.ReadLine();
            int index = 0;
            string returnedWord = "";

            while (ExtractWord(input, index) != "!!!")
            {
                returnedWord = ExtractWord(input, index);
                index += returnedWord.Length + 1;
                if (returnedWord != " " && returnedWord != "")
                {
                    Console.WriteLine(returnedWord + " " + ReturnWordCount(input, returnedWord) + " " + (ReturnWordCount(input, returnedWord) == 1 ? "time" : "times"));
                }                
            }
        }

        public static string ExtractWord(string text, int start)
        {
            if (start >= text.Length)
            {
                return "!!!";
            }
            else
            {
                string currentWord = string.Empty;
                for (int i = start; i < text.Length; i++)
                {
                    if (text[i] == ' ' || text[i] == '.')
                    {
                        break;
                    }
                    else
                    {
                        currentWord += Convert.ToString(text[i]);
                    }
                }
                return currentWord;
            }
        }

        public static int ReturnWordCount(string text, string word)
        {
            int index = 0;
            int count = 0;         

            while (ExtractWord(text, index) != "!!!")
            {
                if (word == ExtractWord(text, index))
                {
                    count++;
                }
                index += ExtractWord(text, index).Length + 1;
            }
            return count;
        }
    }
}
