using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


// You are given a text. Write a program that changes the text in all regions surrounded by the 
// tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

namespace Ex05UppercaseInTags
{
    class Ex05UppercaseInTags
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../textfile.txt");
            using (reader)
            {
                string text = reader.ReadToEnd();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    int index = text.IndexOf("<upcase>", i);
                    if (index != -1)
                    {
                        int index2 = text.IndexOf("</upcase>", i);
                        int lenght = index2 - index - 8;
                        for (int k = index + 8; k < index2; k++)
                        {
                            sb.Append(text[k]);
                        }
                        string tmp = sb.ToString();
                        sb.Clear();
                        text = text.Remove(index, lenght + 17);
                        text = text.Insert(index, tmp.ToUpper());

                        i = index2;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(text);
            }
        }
    }
}
