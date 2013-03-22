using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise11
{
    class Program
    {

        static void Main()
        {
            Console.Write("Please enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the value that will be searched: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the members of the array:");

            int[] givenArray = new int[arrayLenght];

            for (int i = 0; i < givenArray.Length ; i++)
            {
                givenArray[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(givenArray);

            int searchedIndex = Array.BinarySearch(givenArray, value);
            if (searchedIndex > 0)
            {
                Console.WriteLine("The index of the given value is : {0}", searchedIndex);
            }
            else
            {
                Console.WriteLine("The given value was not in the given array");
            }
        }
            
    }
}
