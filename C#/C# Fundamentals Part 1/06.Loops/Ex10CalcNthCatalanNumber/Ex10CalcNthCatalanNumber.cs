using System;

namespace Ex10CalcNthCatalanNumber
{
    class Ex10CalcNthCatalanNumber
    {
        static void Main(string[] args)
        {
            // Same as Exercise 9

            Console.WriteLine("Enter value for N");
            int input = int.Parse(Console.ReadLine());
            int nfaktoriel = 1;
            int i = 1;
            int n2faktoriel = 1;
            int nPlus1faktoriel = 1;
            do
            {
                nfaktoriel *= i;
                i++;

            }
            while (i <= input);

            i = 1;

            while (i <= (2 * input))
            {
                n2faktoriel *= i;
                i++;
            }

            i = 1;

            while (i <= (input + 1))
            {
                nPlus1faktoriel *= i;
                i++;
            }

            Console.WriteLine("{0}th Catalan number is {1}", input, (n2faktoriel / (nPlus1faktoriel * nfaktoriel)));
        }
    }
}
