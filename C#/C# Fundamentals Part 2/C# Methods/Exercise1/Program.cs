using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void HelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);

        }
        static void Main()
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            HelloName(input);
        }
    }
}
