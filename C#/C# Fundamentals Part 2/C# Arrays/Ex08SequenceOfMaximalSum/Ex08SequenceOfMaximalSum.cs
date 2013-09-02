using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the sequence of maximal sum in given array. Example:
// {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?


namespace Ex08SequenceOfMaximalSum
{
    class Ex08SequenceOfMaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];
            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int bestSum = int.MinValue;
            int indexNum = 0;
            int elements = 0;
            int sum = 0;
            int tempSum = 0;
            int counter = 0;

            for (int i = 0; i < arrayLenght; i++)
            {
                sum += array[i];
                counter++;

                if (sum < tempSum && sum <= 0)
                {
                    sum = 0;
                    counter = 0;
                    tempSum = 0;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    indexNum = i;
                    elements = counter;
                }
                if (counter != 0)
                {
                    tempSum += array[i];
                }
            }

            Console.WriteLine("The sequence of elements that have maximal sum is: ");
            for (int i = elements - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[indexNum - i]);
            }
        }
    }
}
