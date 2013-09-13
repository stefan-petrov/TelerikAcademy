using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26]{'A', 'B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            List<string> arr2 = new List<string>();
            int counter = 0;
            int secondCounter = 9;

            while (secondCounter >= 0)
            {
                for (int i = 0; i <= 25; i++)
                {
                    if (secondCounter == 0 & i == 22)
                    {
                        break;
                    }
                    string temp = "";
                    if (counter >= 26 && counter <= 51)
                    {
                        temp += Convert.ToString(arr[0]).ToLower();
                    }
                    else if (counter >= 52 && counter <= 77)
                    {
                        temp += Convert.ToString(arr[1]).ToLower();
                    }
                    else if (counter >= 78 && counter <= 103)
                    {
                        temp += Convert.ToString(arr[2]).ToLower();
                    }
                    else if (counter >= 104 && counter <= 129)
                    {
                        temp += Convert.ToString(arr[3]).ToLower();
                    }
                    else if (counter >= 130 && counter <= 155)
                    {
                        temp += Convert.ToString(arr[4]).ToLower();
                    }
                    else if (counter >= 156 && counter <= 181)
                    {
                        temp += Convert.ToString(arr[5]).ToLower();
                    }
                    else if (counter >= 182 && counter <= 207)
                    {
                        temp += Convert.ToString(arr[6]).ToLower();
                    }
                    else if (counter >= 208 && counter <= 233)
                    {
                        temp += Convert.ToString(arr[7]).ToLower();
                    }
                    else if (counter >= 234 && counter <= 255)
                    {
                        temp += Convert.ToString(arr[8]).ToLower();
                    }
                    temp += Convert.ToString(arr[i]);

                    arr2.Add(temp);
                    counter++;
                }
                secondCounter--;
            }
            

            ulong input = ulong.Parse(Console.ReadLine());
            ulong remainder = Convert.ToUInt64(input % 256);
            input = input / 256;

            List<string> result = new List<string>();
            result.Add(arr2[(int)remainder]);
            
            
            while (input >= 1)
            {
                remainder = Convert.ToUInt64(input % 256);
                input = input / 256;
                result.Add(arr2[(int)remainder]);
                

            }
            
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
