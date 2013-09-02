using System;
using System.Collections.Generic;
using System.Text;


//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

namespace Ex06_20characters
{
    class Ex06_20characters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("Input string too long");
            }
            else if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                int counter = input.Length;

                while (input.Length < 20)
                {
                    input = input.Insert(counter, "*");
                    counter++;
                }
                Console.WriteLine(input);
            }
        }
    }
}
