using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

namespace Ex02ReverseInput
{
    class Ex02ReverseInput
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
