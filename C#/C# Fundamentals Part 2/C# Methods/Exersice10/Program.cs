using System;
using System.Collections.Generic;
using System.Numerics;

namespace Exersice10
{
    class Program
    {
        static BigInteger CalcFaktoriel(int num)
        {
            BigInteger fak = 1;
            for (int i = 1; i <= num; i++)
            {
                fak *= i;
            }
            return fak;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (count <= n)
            {
                Console.WriteLine("Faktoriel of {0} : {1}", count, CalcFaktoriel ( count )  );
                count++;
            }
        }
    }
}
