using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int minVal = 0;
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minVal = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minVal])
                    {
                        minVal = k;
                    }
                }

                temp = array[minVal];
                array[minVal] = array[i];
                array[i] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The given array is now sorted and looks like this: ");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
