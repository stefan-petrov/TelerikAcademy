using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.


namespace Ex12ArrayOfLetters
{
    class Ex12ArrayOfLetters
    {
        static void Main(string[] args)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string input = Console.ReadLine();
            List<char> inputList = new List<char>();

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
