using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            int integersCount = int.Parse(Console.ReadLine());
            int[] array = new int[integersCount];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The bigest of given integers is : {0}", GetMax(array) );

      
        }
    
        static int GetMax(params int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }
    }
}
