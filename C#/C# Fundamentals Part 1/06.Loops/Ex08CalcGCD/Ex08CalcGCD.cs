using System;

namespace Ex08CalcGCD
{
    class Ex08CalcGCD
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int input2 = int.Parse(Console.ReadLine());
            int remainder = 0;
            int quotient;

            while (true)
            {
                quotient = input1 / input2;
                remainder = input1 % input2;
                if (remainder == 0)
                {
                    Console.WriteLine("GCD is {0}", input2);
                    break;
                }

                input1 = input2;
                input2 = remainder;
            }
        }
    }
}
