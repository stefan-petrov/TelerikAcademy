using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * We are given an array of integers and a number S. Write a program to 
// find if there exists a subset of the elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

namespace Ex16SubsetOfElements
{
    class Ex16SubsetOfElements
    {
        static void Main()
        {
            Console.WriteLine("Enter desired sum: ");
            long sum = long.Parse(Console.ReadLine());
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
                    }
                }
                if (currentSum == sum)
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
