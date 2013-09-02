using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.


namespace Ex05MaxIncreasingSequence
{
    class Ex05MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];
            int bigestSequence = 0;
            int index = 0;
            int theNum = 0;
            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSame = array[i] == array[i + 1] - 1;

                if (isSame == true)
                {
                    int counter = 2; ;
                    int n = 1;

                    while (array[i + n] == array[i + 1 + n] - 1)
                    {
                        counter++;
                        n++;

                    }

                    if (counter > bigestSequence)
                    {
                        bigestSequence = counter;
                        index = i;
                        theNum = array[i];
                    }
                }
            }

            Console.WriteLine("The maximal increasing sequence in given array is: ");
            for (int i = 0; i < bigestSequence; i++)
            {
                Console.Write("{0} ", array[index + i]);
            }
        }
    }
}
