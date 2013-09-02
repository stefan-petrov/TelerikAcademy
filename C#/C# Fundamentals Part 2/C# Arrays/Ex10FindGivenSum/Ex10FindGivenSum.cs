using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

namespace Ex10FindGivenSum
{
    class Ex10FindGivenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sum you are looking for: ");
            int givenSum = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int tempSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                tempSum += array[i];

                if (i == array.Length - 1)
                {
                    break;
                }
                else
                {
                    for (int k = i + 1; k < array.Length; k++)
                    {
                        tempSum += array[k];
                        if (tempSum == givenSum)
                        {
                            Print(i, array, k);
                        }
                    }
                    tempSum = 0;
                }
                
            }
            
        }

        private static void Print(int i, int[] arr, int count)
        {      
            for (int k = i ; k <= count; k++)
            {
                    Console.Write(arr[k] + " ");               
            }
                
            Console.WriteLine();
        }
    }
}
