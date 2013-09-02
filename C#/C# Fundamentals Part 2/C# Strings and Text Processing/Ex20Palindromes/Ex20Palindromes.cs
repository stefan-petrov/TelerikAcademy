using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace Ex20Palindromes
{
    class Ex20Palindromes
    {
        public static bool CheckForPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            if (word == "")
            {
                return false;
            }
            else
            {
                return true;
            }       
        }
        
        static void Main(string[] args)
        {
            string text = "just some text containing palindromes like abba and maybe some others like lamal. the idea is to extract all pallindromes like exe and lol etc etc";
            string returnedWord = "";
            int index = 0;

            while (ExtractWord(text, index) != "!!!")
            {
                returnedWord = ExtractWord(text, index);
                index += returnedWord.Length + 1;
                if (CheckForPalindrome(returnedWord))
                {
                    Console.WriteLine(returnedWord);
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
    }
}
