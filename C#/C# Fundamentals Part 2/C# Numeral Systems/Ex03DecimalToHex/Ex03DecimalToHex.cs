using System;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their hexadecimal representation.

namespace Ex03DecimalToHex
{
    class Ex03DecimalToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number you want to convert to Hexadecimal system: ");
            int inputDec = int.Parse(Console.ReadLine());
            int remainder = 0;
            List<string> hexa = new List<string>();
            while (inputDec > 0)
            {
                remainder = inputDec % 16;
                if (remainder >= 0 && remainder <= 9)
                {
                    hexa.Add(Convert.ToString(remainder));
                }
                else
                {
                    if (remainder == 10)
                    {
                        hexa.Add("A");
                    }
                    else if (remainder == 11)
                    {
                        hexa.Add("B");
                    }
                    else if (remainder == 12)
                    {
                        hexa.Add("C");
                    }

                    else if (remainder == 13)
                    {
                        hexa.Add("D");
                    }

                    else if (remainder == 14)
                    {
                        hexa.Add("E");
                    }
                    else if (remainder == 15)
                    {
                        hexa.Add("F");
                    }

                }
                inputDec = inputDec / 16;
            }
            hexa.Reverse();

            foreach (var item in hexa)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
