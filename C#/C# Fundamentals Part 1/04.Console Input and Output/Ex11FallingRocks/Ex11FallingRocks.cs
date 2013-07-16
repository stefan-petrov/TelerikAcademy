using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ex11FallingRocks
{
    class Ex11FallingRocks
    {
       
        static void Main()
        {
            
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine(Console.WindowHeight);
            int dwarfPosition = Console.WindowWidth / 2;
            string hello = "hello";
            char[] test1 = new char[3] { '2', 'a', 's' };
            test1[1] = 'p';
            
            Console.WriteLine(test1[1]);
            string test = hello;
            
            Console.WriteLine(test);
            
            
            
            while (true)
            {
                Redraw(dwarfPosition);               
                Thread.Sleep(150);
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key.ToString() == "LeftArrow")
                {
                    dwarfPosition--;
                }
                else if (input.Key.ToString() == "RightArrow")
                {
                    dwarfPosition++;
                }

                
                
            }
        }

        static void Redraw(int dwarfPos)
        {
            char[] rocksArr = new char[11] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            Console.Clear();
            List<String> generatedRocks = GenerateRocks(rocksArr);
            
            for (int i = 0; i < generatedRocks.Count; i++)
            {
                Console.WriteLine(GenerateRocks(rocksArr)[i]);
            }
                        
            Console.WriteLine("(0)".PadLeft(dwarfPos));
        }

        static List<String> GenerateRocks(char[] rocks)
        {
            List<String> strList = new List<string>();
            
            for (int p = 0; p < 8; p++)
            {
                char[] newLine2 = new char[79];
                
                Random rnd = new Random();
                int randomCharsPerLine = rnd.Next(4, 15);
                StringBuilder sb = new StringBuilder();

                while (randomCharsPerLine >= 0)
                {
                    int randomPosition = rnd.Next(0, 79);
                    int randomSymbol = rnd.Next(0, 11);
                    char charToInsert = rocks[randomSymbol];

                    newLine2[randomPosition] = charToInsert;
                    //for (int i = 0; i < 80; i++)
                    //{
                    //    if (i == randomPosition)
                    //    {
                    //        sb.Append(charToInsert);
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        sb.Append(newLine[i]);
                    //    }
                    //}
                    randomCharsPerLine--;
                }
                
                for (int i = 0; i < newLine2.Length; i++)
                {
                    sb.Append(Convert.ToString(newLine2[i]));
                }

                strList.Add(sb.ToString());
                sb.Clear();
            }

            return strList;
        }
    }
}
