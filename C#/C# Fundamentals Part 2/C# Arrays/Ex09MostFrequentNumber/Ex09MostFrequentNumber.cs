using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace Ex09MostFrequentNumber
{
    class Ex09MostFrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            List<int> inputList = new List<int>();
            int bestCount = 0;
            int counter = 1;
            int theNum = 0;

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                inputList.Add(int.Parse(Console.ReadLine()));
            }

            inputList.Sort();

            for (int i = 0; i < arrayLenght - 1; i++)
            {
                bool isSame = inputList[i] == inputList[i + 1];

                if (isSame)
                {
                    counter++;
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        theNum = inputList[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine("{0}({1} times)", theNum, bestCount);
        }
    }
}
