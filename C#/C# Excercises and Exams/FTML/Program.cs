using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FTML
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();

            while (n > 0)
            {
                string currentLine = Console.ReadLine();
                while (ReplaceTag(currentLine) != "")
                {
                    currentLine = ReplaceTag(currentLine);
                }
                result.Add(currentLine);
                n--;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static string ReplaceTag(string str)
        {
            string temp = FindDeepestTag(str);
            
            Regex rg = new Regex(@"<([a-z]*)>");
            Match match = rg.Match(FindDeepestTag(str));
            StringBuilder sb = new StringBuilder();
            char[] tempStrArr = FindDeepestTag(str).ToCharArray();
            
            int start = str.IndexOf(temp);
            int end = start + temp.Length - 1;
            switch (match.ToString())
            {
                case "<upper>":                    
                    for (int i = start + 7; i < end - 7 ; i++)
                    {
                        sb.Append(Convert.ToString(str[i]).ToUpper());
                    }
                    break;
                case "<lower>":
                    for (int i = start + 7; i < end - 7 ; i++)
                    {
                        sb.Append(Convert.ToString(str[i]).ToLower());
                    }
                    break;
                case "<toggle>":
                    for (int i = start + 8; i < end - 8 ; i++)
                    {
                        if (char.IsLower(str[i]))
                        {
                            sb.Append(Convert.ToString(str[i]).ToUpper());
                        }
                        else
                        {
                            sb.Append(Convert.ToString(str[i]).ToLower());
                        }                        
                    }
                    break;
                case "<del>":
                    
                    return "";
                case "<rev>":
                    for (int i = end - 6; i > start + 4; i--)
                    {
                        sb.Append(str[i]);
                    }
                    break;
                default:
                  return "";
                    
            }

            return str.Replace(temp, sb.ToString());
        }
        
        static List<string> RemoveEmptyCells(List<string> arr)
        {
            List<String> tempList = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != "")
                {
                    tempList.Add(arr[i]);
                }
            }          

            return tempList;
        }

        static string FindDeepestTag(string str)
        {
            string temp = str;
            Regex rg = new Regex(@"<([A-Z][A-Z0-9]*)\b[^>]*>(.*?)</\1>", RegexOptions.IgnoreCase);
            Match match  = rg.Match(temp);
            while (match.Success)
	        {
                temp = match.ToString();
                match = rg.Match(temp, 1);                
	        }
           
            return temp;

        }
    }
}
