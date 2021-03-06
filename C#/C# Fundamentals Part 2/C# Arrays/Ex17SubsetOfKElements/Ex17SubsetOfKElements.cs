﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that reads three integer numbers N, K and S and an array of N 
// elements from the console. Find in the array a subset of K elements that have sum S 
// or indicate about its absence.

namespace Ex17SubsetOfKElements
{
    class Ex17SubsetOfKElements
    {
        static void Main()
        {
            Console.WriteLine("Enter desired sum: ");
            long sum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number for K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            List<string> subsets = new List<string>();

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }
            int count = 0;
            string subset = "";

            for (int i = 1; i <= Math.Pow(2, n) - 1; i++)
            {
                subset = "";
                int countK = 0;
                long currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;

                    if (bit == 1)
                    {
                        currentSum += array[j];
                        subset = subset + " " + array[j];
                        countK++;
                    }
                }
                if (currentSum == sum && countK == k)
                {
                    count++;
                    subsets.Add(subset);
                }

            }

            bool yesOrNo = count > 0;
            if (yesOrNo)
            {
                Console.WriteLine("yes");
                foreach (string item in subsets)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
