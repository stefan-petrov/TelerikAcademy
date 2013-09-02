using System;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

namespace Ex04CountsOfNumberInArray
{
    class Ex04CountsOfNumberInArray
    {
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
                for (int k = i; k < i + 1; k++)
                {
                    if (countArray[array[k]] == 1)
                    {
                        Console.WriteLine(array[k] + " " + countArray[array[k]] + " time");
                    }
                    else
                    {
                        Console.WriteLine(array[k] + " " + countArray[array[k]] + " times");
                    }
                    
                }
            }

        }
    }
}
