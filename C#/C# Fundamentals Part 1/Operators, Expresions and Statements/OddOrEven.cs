using System;

namespace ConsoleApplication4
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Please enter a Number: ");
            int input = int.Parse(Console.ReadLine());            
            int remainder = input % 2;
            Console.WriteLine(remainder == 1 ? "The Number is Odd" : "The Number is Even");
        }
    }
}
