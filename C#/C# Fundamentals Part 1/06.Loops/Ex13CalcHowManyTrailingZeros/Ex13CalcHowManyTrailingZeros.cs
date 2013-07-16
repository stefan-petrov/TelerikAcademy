using System;

namespace Ex13CalcHowManyTrailingZeros
{
    class Ex13CalcHowManyTrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                int devider = i;
                while (devider % 5 == 0)
                {
                    counter++;
                    devider /= 5;
                }
            }

            Console.WriteLine("Trailing zeros after N! " +  counter);
        }
    }
}
