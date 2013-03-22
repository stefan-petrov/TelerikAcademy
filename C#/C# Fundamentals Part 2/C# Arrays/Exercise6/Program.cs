using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter K - the number of elements that have maximal sum: ");
            int k = int.Parse(Console.ReadLine());
            
            List<int> inputList = new List<int>();
            List<int> maxSumList = new List<int>();

            Console.WriteLine("Enter the members of the array: ");
            for (int i = 0; i < n; i++)
			{			 
                inputList.Add(int.Parse(Console.ReadLine()));              
            }

            for (int i = 0; i < k; i++)
            {
                inputList.Sort();
                maxSumList.Add(inputList[n - 1]);
                inputList.Remove(inputList[n - 1]);
                n--;
            }

            Console.WriteLine("The elements that have maximal sum in the array are: ");
            for (int i = 0; i < maxSumList.Count; i++)
            {
                Console.Write("{0} ", maxSumList[i]);
            }
        }
    }
}
