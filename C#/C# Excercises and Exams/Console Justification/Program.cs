using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleJustification
{
    class Program
    {
        static void Main(string[] args)
        {           
            int n = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            List<string> wholeText = new List<string>();
            while (n > 0)
            {
                string[] currentLine = Console.ReadLine().Split(new string[]{" ", "  ", "   "}, StringSplitOptions.RemoveEmptyEntries);
                n--;
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (currentLine[i] != "")
                    {
                        wholeText.Add(currentLine[i]);
                    }
                    
                }
            }

            int curentTotalLenght = 0;
            int start = 0;
            for (int i = 0; i < wholeText.Count; i++)
            {               
                curentTotalLenght += wholeText[i].Length + 1;
                if (curentTotalLenght - 1 < w && i != wholeText.Count - 1)
                {                  
                    continue;
                }
                else if (curentTotalLenght - 1 == w & i != wholeText.Count - 1)
                {
                    PrintLine(start, i , wholeText, w);
                    curentTotalLenght = 0;
                    start = i + 1;                   
                }
                else if (curentTotalLenght - 1 <= w && i == wholeText.Count - 1)
                {
                    Console.WriteLine(wholeText[i].TrimEnd());
                }
                else
                {                  
                    PrintLine(start, i - 1, wholeText, w);
                    curentTotalLenght = 0;
                    start = i;
                    i--;
                }

            }
        }

        private static void PrintLine(int start, int end, List<string> list, int w)
        {
            int gapsCount = end - start;          
            int totalWordsChars = 0;
            if (gapsCount <= 0)
            {
                Console.WriteLine(list[start].TrimEnd());
                return;
            }
            for (int i = start; i <= end; i++)
            {
                totalWordsChars += list[i].Length;
            }

            int remainder = w - totalWordsChars;
            int gapsSpace = 0;
            if (gapsCount != 0)
            {
                gapsSpace = remainder / gapsCount;  
            }
           
            

            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                sb.Append(list[i]);
                if (i != end)
                {
                    sb.Append(new string(' ', gapsSpace));
                }
            }
            string temp = sb.ToString();
            Regex rg = new Regex(@"\s+");
            MatchCollection matches = rg.Matches(temp);
            int counter = 0;
            while (temp.Length < w)
            {
                sb.Insert(matches[counter].Index + 1, " ");
                matches = rg.Matches(temp);
                counter++;
                temp = sb.ToString();
            }

            Console.WriteLine(temp);
        }
    }
}
