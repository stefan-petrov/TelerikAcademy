using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace Ex24PrintListOfWords
{
    class Ex24PrintListOfWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text: ");
            string str = Console.ReadLine();

            List<string> words = new List<string>();

            foreach (Match word in Regex.Matches(str, @"\w+"))
            {
                words.Add(word.Value);
            }
            words.Sort();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
