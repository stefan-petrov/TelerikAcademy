using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

namespace Ex07SortingArray
{
    class Ex07SortingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int minValIndex = 0;
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minValIndex = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minValIndex])
                    {
                        minValIndex = k;
                    }
                }

                temp = array[minValIndex];
                array[minValIndex] = array[i];
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
