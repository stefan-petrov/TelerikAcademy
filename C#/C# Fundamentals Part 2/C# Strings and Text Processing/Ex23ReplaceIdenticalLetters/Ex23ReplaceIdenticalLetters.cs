using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string from the console and replaces all series of 
// consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace Ex23ReplaceIdenticalLetters
{
    class Ex23ReplaceIdenticalLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (((i + 1) < (input.Length)) && (input[i] != input[i + 1]))
                {
                    sb.Append(input[i]);
                }
            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
