using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            
            List<int> inputList = new List<int>();
            int bestCount = 0;
            int counter = 1;
            int theNum = 0;
            
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                inputList.Add(int.Parse(Console.ReadLine()));
            }

            
            
            inputList.Sort();

            for (int i = 0; i < n-1; i++)
            {
                bool isSame = inputList[i] == inputList[i+1];

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
