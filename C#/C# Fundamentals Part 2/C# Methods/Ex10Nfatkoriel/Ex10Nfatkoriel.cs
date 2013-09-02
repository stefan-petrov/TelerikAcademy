using System;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100]. 
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

namespace Ex10Nfatkoriel
{
    class Ex10Nfatkoriel
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
                Console.WriteLine("Faktoriel of {0} : {1}", count, CalcFaktoriel(count));
                count++;
            }
        }
    }
}
