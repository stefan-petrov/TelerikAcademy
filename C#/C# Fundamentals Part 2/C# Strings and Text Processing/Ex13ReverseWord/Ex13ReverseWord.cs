using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reverses the words in given sentence.
	// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

namespace Ex13ReverseWord
{
    class Ex13ReverseWord
    {
        static void Main(string[] args)
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            List<string> reversedInput = new List<string>();
            int startWordIndex = 0;
            char endSentenceChar = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == ':' || input[i] == ',' || input[i] == '.' || input[i] == '!' || input[i] == '?')
                {
                    StringBuilder sb = new StringBuilder();
                    for (int k = startWordIndex; k < i; k++)
                    {
                        sb.Append(input[k]);
                    }
                    reversedInput.Add(sb.ToString());

                    if (input[i] == ',')
                    {
                        reversedInput.Add(Convert.ToString(input[i]));
                    }

                    if (input[i] == '.' || input[i] == '?' || input[i] == '!')
                    {
                        endSentenceChar = input[i];
                    }

                    if (input[i] == ',' || input[i] == ':')
                    {
                        startWordIndex = i + 2;
                        i++;
                    }
                    else
                    {
                        startWordIndex = i + 1;
                    }
                    sb.Clear();
                }
            }

            reversedInput.Reverse();
            StringBuilder finalSb = new StringBuilder();

            for (int i = 0; i < reversedInput.Count; i++)
            {
                if (i == 0 || reversedInput[i] == "," || reversedInput[i] == ":")
                {
                    finalSb.Append(reversedInput[i]);
                }
                else
                {
                    finalSb.Append(" ");
                    finalSb.Append(reversedInput[i]);
                }

            }
            finalSb.Append(endSentenceChar);
            string reversedSentence = finalSb.ToString();
            Console.WriteLine(reversedSentence);
        }
    }
}
