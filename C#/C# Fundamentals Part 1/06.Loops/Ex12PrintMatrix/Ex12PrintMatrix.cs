using System;

namespace Ex12PrintMatrix
{
    class Ex12PrintMatrix
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 1; i <= matrix.GetLength(0); i++)
            {
                for (int k = i; k < matrix.GetLength(1) + i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
