using System;
using System.Collections.Generic;

namespace Exercise8
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

            int bestSum = int.MinValue;
            int indexNum = 0;
            int elements = 0;
            int sum = 0;
            int tempSum = 0;
            int counter = 0;
            
            for (int i = 0; i < n  ; i++)
            {
                sum += array[i];
                counter++;

                if (sum < tempSum && sum <= 0)
                {
                    sum = 0;
                    counter = 0;
                    tempSum = 0;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    indexNum = i;
                    elements = counter;
                }
                if (counter != 0)
                {
                    tempSum += array[i];
                }
            }

            Console.WriteLine("The sequence of elements that have maximal sum is: ");
            for (int i = elements - 1  ; i >= 0; i--)
            {
                Console.Write("{0} ", array[indexNum - i]);
            }
        }
    }
}
