using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two numbers N and K and generates all the variations of K 
// elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


namespace Ex20Variations
{
    class Ex20Variations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N (to generate from 1 to N)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter K:");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Variations(array, 0, n);
        }

        static void Variations(int[] array, int index, int n)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    Variations(array, index + 1, n);
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
