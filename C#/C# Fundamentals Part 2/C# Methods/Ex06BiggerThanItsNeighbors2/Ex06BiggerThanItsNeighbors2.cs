using System;

// Write a method that returns the index of the first element in array that is bigger than its neighbors, 
// or -1, if there’s no such element.
// Use the method from the previous exercise.

namespace Ex06BiggerThanItsNeighbors2
{
    class Ex06BiggerThanItsNeighbors2
    {     

        static bool CheckForBigest(int[] array, int index)
        {
            bool isBigger = true;
            if (index < array.Length - 1 && index >= 1)
            {
                isBigger = array[index] > array[index + 1] && array[index] > array[index - 1];
            }
            else if (index >= array.Length - 1)
            {
                isBigger = array[index] > array[index - 1];
            }
            else if (index < 1)
            {
                isBigger = array[index] > array[index + 1];
            }
            return isBigger;

        }

        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] - ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------------------------------");
            
            
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (CheckForBigest(array, i))
                {
                     Console.WriteLine("The first element in the given array");
                     Console.WriteLine("that is bigger than its neighbours is with index: ");
                     Console.WriteLine("{0} ", i);
                     break;
                }
                else if (i == array.Length - 2)
                {
                     Console.WriteLine(-1);
                }
            }         
        }
    }
}
