using System;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their binary representation.

namespace Ex01DecimalToBinary
{
    class Ex01DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number you want to convert to binary system: ");
            int inputDec = int.Parse(Console.ReadLine());
            int remainder = 0;
            List<int> binary = new List<int>();
            while (inputDec > 0)
            {
                remainder = inputDec % 2;
                binary.Add(remainder);
                inputDec = inputDec / 2;
            }
            binary.Reverse();

            foreach (var item in binary)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
