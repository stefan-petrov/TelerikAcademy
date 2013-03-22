using System;
using System.Collections.Generic;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sum you are looking for: ");
            int givenSum = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            
            int indexNum = 0;
            int elements = 0;
            int sum = 0;
            int counter = 0;
            int previousSum = 0;
            
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                counter++;

                if (sum > givenSum && sum > previousSum)
                {
                        sum = array[i];
                        counter = 1;
                        previousSum = 0;

                }
                if (sum == givenSum)
                {                   
                    indexNum = i;
                    elements = counter;
                }

                previousSum += array[i];
            }

            if (elements > 0)
            {
                Console.WriteLine("The elements with such given sum are: ");
                for (int i = 0; i < elements; i++)
                {
                    Console.Write("{0} ", array[indexNum - elements + i + 1]);
                }
            }
            else
            {
                Console.WriteLine("No such sum");
            }
        }
    }
}
