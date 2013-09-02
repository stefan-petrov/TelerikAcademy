using System;

// Write a method that checks if the element at given position in given array of 
// integers is bigger than its two neighbors (when such exist).

namespace Ex05BiggerThanItsNeighbors
{
    class Program
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
            Console.WriteLine("Lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Position: ");
            int pos = int.Parse(Console.ReadLine());
            if ((pos > n - 1) || pos < 0)
            {
                Console.WriteLine("Invalid position. Please try again");
            }
            else
            {
                int[] array = new int[n];
                Console.WriteLine("Elements of the array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("[{0}] - ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }

                bool isBigger = CheckForBigest(array, pos);

                if (isBigger)
                {
                    Console.WriteLine("The Element Is Bigger Than Its Neighbor/s");
                }
                else
                {
                    Console.WriteLine("The Element Is Not Bigger Than Its Neighbor/s");
                }
            }        
        }
    }
}
