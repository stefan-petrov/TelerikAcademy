using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program that finds the index of given element in a sorted array of 
//  integers by using the binary search algorithm (find it in Wikipedia).

namespace Ex11BinarySearch
{
    class Ex11BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the value that will be searched: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the members of the array:");

            int[] array = new int[arrayLenght];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            bool isFound = false;

            int start = 0;
            int end = array.Length - 1;
            int mid = (end - start) / 2;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (array[mid] < value)
                {
                    start = mid + 1;
                    continue;
                }
                else if (array[mid] > value)
                {
                    end = mid - 1;
                }
                else
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("The searched value is at index " + mid);
            }
            else
            {
                Console.WriteLine("Not Found");
            }                  
        }
    }
}
