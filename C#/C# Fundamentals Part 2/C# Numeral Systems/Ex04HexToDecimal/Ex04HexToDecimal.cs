using System;

// Write a program to convert hexadecimal numbers to their decimal representation.

namespace Ex04HexToDecimal
{
    class Ex04HexToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in Hexadecimal system that you want to convert to decimal system: ");
            string input = Console.ReadLine();
            char[] inputAsChar = input.ToCharArray();
            string[] inputAsString = new string[inputAsChar.Length];

            for (int i = 0; i < inputAsChar.Length; i++)
            {
                inputAsString[i] = Convert.ToString(inputAsChar[i]);
            }
            int[] inputAsInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int number;
                bool result = Int32.TryParse(inputAsString[i], out number);
                if (result)
                {
                    inputAsInt[i] = int.Parse(inputAsString[i]);
                }
                else
                {
                    if (inputAsString[i] == "A" || inputAsString[i] == "a")
                    {
                        inputAsInt[i] = 10;
                    }
                    else if (inputAsString[i] == "B" || inputAsString[i] == "b")
                    {
                        inputAsInt[i] = 11;
                    }
                    else if (inputAsString[i] == "C" || inputAsString[i] == "c")
                    {
                        inputAsInt[i] = 12;
                    }
                    else if (inputAsString[i] == "D" || inputAsString[i] == "d")
                    {
                        inputAsInt[i] = 13;
                    }
                    else if (inputAsString[i] == "E" || inputAsString[i] == "e")
                    {
                        inputAsInt[i] = 14;
                    }
                    else if (inputAsString[i] == "F" || inputAsString[i] == "f")
                    {
                        inputAsInt[i] = 15;
                    }
                }
            }

            Array.Reverse(inputAsInt);

            double sum = 0;
            for (int i = 0; i < inputAsInt.Length; i++)
            {
                sum += inputAsInt[i] * Math.Pow(16, i);
            }

            Console.WriteLine(sum);
        }
    }
}
