using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for K: ");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] arrayK = new int[k + 1];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayK.Length; i++)
			{
			    arrayK[i] = i;
			}

            Array.Sort(array);
            Array.Sort(arrayK);
            Array.Reverse(arrayK);

            int largest = int.MinValue;

            for (int i = 0; i < arrayK.Length; i++)
            {
                int current = Array.BinarySearch(array, arrayK[i]);
                if (current > 0)
                {
                    largest = arrayK[i];
                    break;
                }
            }
            
            Console.WriteLine(largest);
        }
    }
}
