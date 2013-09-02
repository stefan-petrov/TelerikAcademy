using System;
using System.Collections.Generic;

// Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace Ex05HexToBinary
{
    class Ex05HexToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in Hexadecimal system that you want to convert to binary system: ");
            string input = Console.ReadLine();
            List<string> inputAsBinary = new List<string>();

            for (int i = 0; i < input.Length ; i++)
            {
                if (input[i] == '0')
                {
                    inputAsBinary.Add("0000");
                }
                else if (input[i] == '1')
                {
                    inputAsBinary.Add("0001");
                }
                else if (input[i] == '2')
                {
                    inputAsBinary.Add("0010");
                }
                else if (input[i] == '3')
                {
                    inputAsBinary.Add("0011");
                }
                else if (input[i] == '4')
                {
                    inputAsBinary.Add("0100");
                }
                else if (input[i] == '5')
                {
                    inputAsBinary.Add("0101");
                }
                else if (input[i] == '6')
                {
                    inputAsBinary.Add("0110");
                }
                else if (input[i] == '7')
                {
                    inputAsBinary.Add("0111");
                }
                else if (input[i] == '8')
                {
                    inputAsBinary.Add("1000");
                }
                else if (input[i] == '9')
                {
                    inputAsBinary.Add("1001");
                }
                else if (input[i] == 'A' || input[i] == 'a')
                {
                    inputAsBinary.Add("1010");
                }
                else if (input[i] == 'B' || input[i] == 'b')
                {
                    inputAsBinary.Add("1011");
                }
                else if (input[i] == 'C' || input[i] == 'c')
                {
                    inputAsBinary.Add("1100");
                }
                else if (input[i] == 'D' || input[i] == 'd')
                {
                    inputAsBinary.Add("1101");
                }
                else if (input[i] == 'E' || input[i] == 'e')
                {
                    inputAsBinary.Add("1110");
                }
                else if (input[i] == 'F' || input[i] == 'f')
                {
                    inputAsBinary.Add("1111");
                }
            }

            foreach (string str in inputAsBinary)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            
        }
    }
}
