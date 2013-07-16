using System;

namespace Ex01OddOrEven
{
    class Ex01OddOrEven
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            int remainder = input % 2;
            Console.WriteLine(remainder == 1 ? "The Number is Odd" : "The Number is Even");
        }
    }
}
