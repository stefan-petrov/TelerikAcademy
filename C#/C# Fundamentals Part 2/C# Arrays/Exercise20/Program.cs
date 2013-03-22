using System;
using System.Collections.Generic;

namespace Exerise20
{
    class Program
    {
        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            int inputK = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(inputN, inputK); i++)
            {
                int tmp = i;
                int[] nums = new int[inputK];
                for (int k = 0; k < inputK; k++)
                {
                    nums[inputK - k - 1] = tmp % inputN;
                    tmp = tmp / inputN;
                }

                Console.Write("{0}", nums[0] + 1);
                for (int j = 1; j < inputK; j++)
                {
                    Console.Write(" {0}", nums[j] + 1);
                }
                Console.WriteLine();
            }
        }
    }
}