using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static bool IsBigger(int[] somearray, int index)
        {
            bool isBigger = true;
            if (index < somearray.Length - 1 && index >= 1)
            {
                isBigger = somearray[index] > somearray[index + 1] && somearray[index] > somearray[index - 1];
            }
            else if (index >= somearray.Length - 1)
            {
                isBigger = somearray[index] > somearray[index - 1];
            }
            else if (index < 1)
            {
                isBigger = somearray[index] > somearray[index + 1];
            }
            return isBigger;
            
        }
        static void Main()
        {
            Console.WriteLine("Lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Position: ");
            int pos = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool bigger = IsBigger(array, pos);
                  

            if (bigger)
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
