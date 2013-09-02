using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.


namespace Ex06FindMaximalSum
{
    class Ex06FindMaximalSum
    {
        static void Main(string[] args)
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
                Console.Write("[{0}] = ", i);
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
