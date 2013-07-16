using System;

namespace Ex08PrintNumbersFrom1ToN
{
    class Ex08PrintNumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
