using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Write a program that extracts from a given text all sentences containing given word.

namespace Ex08ExtractSentences
{
    class Ex08ExtractSentences
    {
        static void PrintSentence(string str, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            return;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../textfile.txt");
            string allText;
            using (reader)
            {
                allText = reader.ReadToEnd();
            }
            int position = 0;
            int wordIndex = allText.IndexOf(" in ", position + 1);

            while (wordIndex != -1)
            {
                int sentenceEnd = 0;
                int sentenceBegin = 0;

                position = wordIndex;
                if (wordIndex != -1)
                {

                    for (int i = position; i < allText.Length; i++)
                    {
                        if (allText[i] == '.')
                        {
                            sentenceEnd = i;
                            break;
                        }
                    }
                    for (int i = position; i >= 0; i--)
                    {
                        if (allText[i] == '.')
                        {
                            if (allText[i + 1] == ' ')
                            {
                                sentenceBegin = i + 2;
                                break;
                            }
                            else
                            {
                                sentenceBegin = i + 1;
                                break;
                            }
                        }
                        if (i == 0)
                        {
                            sentenceBegin = 0;
                        }
                    }
                }

                PrintSentence(allText, sentenceBegin, sentenceEnd);
                allText = allText.Remove(sentenceBegin, sentenceEnd - sentenceBegin);
                wordIndex = allText.IndexOf(" in ");
            }
        }
    }
}
