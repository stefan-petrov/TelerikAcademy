using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        
        // This code prints how many times in given by user array the numbers appears
        // Example: given array : {1, 4, 5, 4, 1, 2}
        // The output will look like: 1  2
        //                            4  2
        //                            5  1
        //                            4  2
        //                            1  2
        //                            2  1
        
        static int[] GetCount(int[] array)
        {
            int[] countingArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                countingArray[array[i]]++;
            }

            return countingArray;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] countArray = GetCount(array);
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < i+1; k++)
                {
                    Console.WriteLine(array[k] + " " + countArray[array[k]] + " times");
                }
            }
            
        }
    }
}
