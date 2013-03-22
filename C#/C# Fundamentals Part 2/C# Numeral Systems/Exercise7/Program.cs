using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static double ToDec(string str, int s)
        {
            char[] charArr = str.ToCharArray();
            double sum = 0;
            
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] > '9')
                {
                    sum += (charArr[i] - '7') * Math.Pow(s, charArr.Length - i - 1);
                }
                else
                {
                    sum += (charArr[i] - '0') * Math.Pow(s, charArr.Length - i - 1);
                }
            }
            return sum;
        }


        static List<string> FromDecToD(int num, int d)
        {
            List<string> result = new List<string>();
            int remainder = 0;
            
            while (num > 0)
            {
                remainder = (int)num % d;

                if (remainder >= 0 && remainder <= 9)
                {                   
                    result.Add(remainder.ToString());
                    num = num / d;
                }
                else
                {
                    if (remainder == 10)
                    {
                        result.Add("A");
                        num = num / d;
                    }
                    else if (remainder == 11)
                    {
                        result.Add("B");
                        num = num / d;
                    }
                    else if (remainder == 12)
                    {
                        result.Add("C");
                        num = num / d;
                    }

                    else if (remainder == 13)
                    {
                        result.Add("D");
                        num = num / d;
                    }

                    else if (remainder == 14)
                    {
                        result.Add("E");
                        num = num / d;
                    }
                    else if (remainder == 15)
                    {
                        result.Add("F");
                        num = num / d;
                    }
                }     
            }
            result.Reverse();
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number you want to convert :");
            string input = Console.ReadLine().ToUpper();
            int s = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            
            int temp = (int)ToDec(input, s);
            foreach (var item in FromDecToD( temp , d ))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
