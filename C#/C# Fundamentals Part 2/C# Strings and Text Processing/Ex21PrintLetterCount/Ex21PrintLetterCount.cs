using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string from the console and prints all different 
// letters in the string along with information how many times each letter is found. 

namespace Ex21PrintLetterCount
{
    class Ex21PrintLetterCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} - {1} time\\times", input[i], ReturnLetterCount(input, input[i]));
            }
        }

        public static int ReturnLetterCount(string text, char letter)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
