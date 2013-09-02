﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that allocates array of 20 integers 
// and initializes each element by its index multiplied by 5. 
// Print the obtained array on the console.


namespace Ex01ArrayOf20Integers
{
    class Ex01ArrayOf20Integers
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * 5;
            }

            foreach (var number in array)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }
    }
}
