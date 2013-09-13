using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DurankulakNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            List<string> arr2 = new List<string>();
            int counter = 0;
            int secondCounter = 7;

            while (secondCounter > 0)
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
                    else if (counter >= 156 && counter <= 167)
                    {
                        temp += Convert.ToString(arr[5]).ToLower();
                    }
                   
                    temp += Convert.ToString(arr[i]);

                    arr2.Add(temp);
                    counter++;
                }
                secondCounter--;
            }
            string[] strArr = new string[arr2.Count];
            for (int i = 0; i < arr2.Count; i++)
			{
			 strArr[i] = arr2[i];
			}

            string input = Console.ReadLine();
            List<string> list = new List<string>();
            string temp2 = "";
            for (int i = 0; i < input.Length; i++)
            {               
                if (char.IsLower(input[i]))
                {
                    temp2+=Convert.ToString(input[i]);
                }
                else
                {
                    list.Add(temp2 + Convert.ToString(input[i]));
                    temp2 = "";
                }
                
            }
            BigInteger result = 0;
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                string currentStr = list[i];
                int index = Array.IndexOf(strArr, currentStr);
                result += index * PowerOf167(i); 
            }

            Console.WriteLine(result);
            
        }

        private static BigInteger PowerOf167(int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 168;
            }
            return result;
        }
    }
}
