using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in binary system that you want to convert to Hexadecimal system: ");
            string input = Console.ReadLine();
            char[] inputAsChar = input.ToCharArray();
            string[] inputAsString = new string[inputAsChar.Length];

            for (int i = 0; i < inputAsChar.Length; i++)
            {
                inputAsString[i] = Convert.ToString(inputAsChar[i]);
            }
            int[] inputAsInt = new int[input.Length];
            List<string> listString = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";
                int counter = 4;
                while (counter > 0)
                {
                    temp += inputAsString[i];
                    counter--;
                    i++;
                }
                i--;

                string tempAsHexa = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                listString.Add(tempAsHexa);   
                                 
            }
         
            foreach (var item in listString)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

