using System;
using System.Collections.Generic;

namespace Exercise12
{
    class Program
    {
        static void Main()
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string input = Console.ReadLine();
            List<char> inputList= new List<char>();

            foreach (char c in input.ToLower())
            {
                inputList.Add(c);
            }

            foreach (char c in inputList)
            {
                int searchedIndex = Array.BinarySearch(alphabet, c.ToString());

                if (searchedIndex < 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("{0} ", searchedIndex);
                }
            }
        }

    }
}
