using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two numbers N and K and generates all the combinations of K 
// distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


namespace Ex21Combinations
{
    class Ex21Combinations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N (to generate from 1 to N)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter K:");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Combinations(array, 0, 1, n);
        }

        static void Combinations(int[] array, int index, int num, int n)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = num; i <= n; i++)
                {
                    array[index] = i;
                    Combinations(array, index + 1, i + 1, n);
                }
            }
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
