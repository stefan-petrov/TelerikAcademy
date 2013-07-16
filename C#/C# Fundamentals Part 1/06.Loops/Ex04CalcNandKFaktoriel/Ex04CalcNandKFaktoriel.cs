using System;

namespace Ex04CalcNandKFaktoriel
{
    class Ex04CalcNandKFaktoriel
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for N (N must be > 1)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for K (K must be < N and > 1)");
            int k = int.Parse(Console.ReadLine());
            int nfaktoriel = 1;
            int kfaktoriel = 1;
            int i = 1;

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
            
            decimal result = (decimal)nfaktoriel / (decimal)kfaktoriel;
            Console.WriteLine("N!/K! = " + result);           
        }
    }
}
