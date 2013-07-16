using System;

namespace Ex07FirstNfromFibonacci
{
    class Ex07FirstNfromFibonacci
    {
        static void Main()
        {
            Console.WriteLine("Please enter number N");
            int input = int.Parse(Console.ReadLine());
            int fib1Num = 0;
            int fib2Num = 1;
            int fibSum = 0;
            int sumNmembers = 0;

            for (int i = 1; i < input; i++)
            {
                fibSum = fib1Num + fib2Num;
                fib1Num = fib2Num;
                fib2Num = fibSum;

                sumNmembers += fib1Num;
            }
            
            Console.WriteLine(sumNmembers);
        }
    }
}
