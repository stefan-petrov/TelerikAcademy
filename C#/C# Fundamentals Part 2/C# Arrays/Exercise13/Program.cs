using System;
using System.Collections.Generic;

namespace Exercise13
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine()); 
            }
            int middle = intArray.Length / 2;
            
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (intArray.Length % 2 == 0)
            {
                for (int row = 0; row < intArray.Length / 2; row++)
                {
                    for (int i = 0; i < intArray.Length / 2; i++)
                    {
                        left.Add(intArray[i]);
                        right.Add(intArray[intArray.Length / 2 + i]);
                    }
                }
            }
        
        
        
        
        
        
        
        }
    }
}
