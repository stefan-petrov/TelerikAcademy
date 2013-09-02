using System;
using System.Collections.Generic;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace Ex06BinaryToHex
{
    class Ex06BinaryToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in binary system that you want to convert to Hexadecimal system: ");
            string input = Console.ReadLine();
            List<string> inputAsHex = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";
                
                for (int k = 0; k < 4; k++)
			    {
                    temp += input[i];
                    i++;
			    }
                i--;
                
                if (temp == "0000")
                {
                    inputAsHex.Add("0");
                }
                else if (temp == "0001")
                {
                    inputAsHex.Add("1");
                }
                else if (temp == "0010")
                {
                    inputAsHex.Add("2");
                }
                else if (temp == "0011")
                {
                    inputAsHex.Add("3");
                }
                else if (temp == "0100")
                {
                    inputAsHex.Add("4");
                }
                else if (temp == "0101")
                {
                    inputAsHex.Add("5");
                }
                else if (temp == "0110")
                {
                    inputAsHex.Add("6");
                }
                else if (temp == "0111")
                {
                    inputAsHex.Add("7");
                }
                else if (temp == "1000")
                {
                    inputAsHex.Add("8");
                }
                else if (temp == "1001")
                {
                    inputAsHex.Add("9");
                }
                else if (temp == "1010")
                {
                    inputAsHex.Add("A");
                }
                else if (temp == "1011")
                {
                    inputAsHex.Add("B");
                }
                else if (temp == "1100")
                {
                    inputAsHex.Add("C");
                }
                else if (temp == "1101")
                {
                    inputAsHex.Add("D");
                }
                else if (temp == "1110")
                {
                    inputAsHex.Add("E");
                }
                else if (temp == "1111")
                {
                    inputAsHex.Add("F");
                }
            }

            foreach (string str in inputAsHex)
            {
                Console.Write(str);
            }
            Console.WriteLine();            
        }
    }
}
