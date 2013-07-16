using System;
using System.Numerics;

namespace Ex05CalcNandKFaktoriels2
{
    class Ex05CalcNandKFaktoriels2
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for N (N must be > 1)");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for K (K must be > N and > 1)");
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger nfaktoriel = 1;
            BigInteger kfaktoriel = 1;
            BigInteger i = 1;

            do
            {
                nfaktoriel *= i;
                i++;
            }
            while (i <= n);

            i = 1;

            do
            {
                kfaktoriel *= i;
                i++;

            }
            while (i <= k);

            Console.Write("N!*K!/(K-N) = ");
            Console.WriteLine((nfaktoriel * kfaktoriel) / (k - n));
        }
    }
}
