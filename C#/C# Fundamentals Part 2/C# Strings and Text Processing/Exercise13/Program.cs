using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence to be reversed: ");
            string input = Console.ReadLine();
            List<string> reversedInput = new List<string>();
            int startWordIndex = 0;
            char endSentenceChar = ' ';
            for (int i = 0; i < input.Length; i++)
            {     
                if (input[i] == ' ' || input[i] == ':' || input[i] == ',' || input[i] == '.' || input[i] == '!' || input[i] == '?' )
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
            
            for (int i = 0 ;i < reversedInput.Count; i++ )
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
