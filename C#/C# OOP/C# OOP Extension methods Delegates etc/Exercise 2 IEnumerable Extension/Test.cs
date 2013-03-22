using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise2
{ 
    class Test
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5,8,9,2,13,5 , 1};
            
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Product());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());
        }
    }
}
