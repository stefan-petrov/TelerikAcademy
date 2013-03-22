using System;
using System.Collections.Generic;

namespace Exercise14
{
    class Program
    {
        static void Main()
        {
            int n = 10000000;
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i;
            }

            int p = 2;
            List<int> primes = new List<int>();

            while (p < n)
            {
                for (int i = 2; i < n; i++)
                {
                    if (i + p > n - 1)
                    {
                        break;
                    }
                    if (i % p == 0)
                    {
                        numbers[i + p] = 0;
                    }
                }

                for (int i = p; i < n; i++)
                {
                    if (numbers[i] != 0 && numbers[i] > p)
                    {

                        p = numbers[i];
                        //primes.Add(p);
                        Console.Write("{0} ", p);

                        break;
                    }
                }
            }

            for (int i = 0; i < primes.Count; i++)
            {
                Console.WriteLine(primes[i]);
            }

        }
    }
}
