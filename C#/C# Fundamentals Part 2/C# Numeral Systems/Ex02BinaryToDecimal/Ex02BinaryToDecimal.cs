using System;

// Write a program to convert binary numbers to their decimal representation.

namespace Ex02BinaryToDecimal
{
    class Ex02BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in binary system that you want to convert to decimal system: ");
            string input = Console.ReadLine();
            char[] inputAsChar = input.ToCharArray();
            int[] inputAsInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputAsInt[i] = int.Parse(inputAsChar[i].ToString());
            }

            Array.Reverse(inputAsInt);

            double sum = 0;
            for (int i = 0; i < inputAsInt.Length; i++)
            {
                sum += inputAsInt[i] * Math.Pow(2, i);
            }

            Console.WriteLine(sum);
        }
    }
}
