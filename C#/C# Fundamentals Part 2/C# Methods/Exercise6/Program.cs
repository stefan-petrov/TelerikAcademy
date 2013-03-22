using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {

        static int ReturnIndex(int[] somearray )
        {
            for (int i = 1; i < somearray.Length - 1; i++)
            {
               
                if (somearray[i] > somearray[i - 1] && somearray[i] > somearray[i + 1])
                {
                    return i;
                }
                else if (i == somearray.Length - 2)
                {
                    return -1;
                } 
            }
            return -1;
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
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("-------------------------------");
            if (ReturnIndex(array) > 0)
            {
                Console.WriteLine("The first element in the given array");
                Console.WriteLine("that is bigger than its neighbours is with index: ");
                Console.WriteLine("{0} ", ReturnIndex(array));
            }

            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
