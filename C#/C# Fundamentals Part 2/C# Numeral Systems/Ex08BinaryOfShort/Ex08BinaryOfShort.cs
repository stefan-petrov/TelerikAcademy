using System;
using System.Collections.Generic;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace Ex08BinaryOfShort
{
    class Ex08BinaryOfShort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter signed short(8-bit) number that you want to convert to binary : ");
            string input = Console.ReadLine();
            int inputAsDecimal = 0;
            string temp = "";
            bool isNegative = false;
            if (input[0] == '0')
            {            
                for (int i = 1; i < input.Length; i++)
                {
                    temp += input[i];
                }
                inputAsDecimal = ToDec(temp);
            }
            else
            {
                isNegative = true;
                for (int i = 1; i < input.Length; i++)
                {
                    temp += input[i];
                }
                inputAsDecimal = 128 - ToDec(temp);
            }

            if (isNegative)
            {
                Console.WriteLine("-" + inputAsDecimal);
            }
            else
            {
                Console.WriteLine(inputAsDecimal);
            }
           
        }

        public static int ToDec(string s)
        {
            List<char> reversed = new List<char>();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed.Add(s[i]);
            }
            
            double sum = 0;
            for (int i = 0; i < reversed.Count; i++)
            {
                sum += Convert.ToInt32(reversed[i]  - 48) * Math.Pow(2, i);
            }
            return (int)sum;
        }
    }
}
