using System;

// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


namespace Ex04UsingBinarySearch
{
    class Ex04UsingBinarySearch
    {
        static void Main(string[] args)
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
