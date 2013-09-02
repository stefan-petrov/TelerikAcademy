using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two char arrays lexicographically (letter by letter).


namespace Ex03CompareCharArraysLexicographically
{
    class Ex03CompareCharArraysLexicographically
    {
        static void Main()
        {
            Console.Write("Enter the first char array : ");
            string array1input = Console.ReadLine();
            int array1Lenght = array1input.Length;

            char[] firstArray = array1input.ToCharArray();

            Console.Write("Enter the second char array : ");
            string array2input = Console.ReadLine();
            int array2Lenght = array1input.Length;

            char[] secondArray = array2input.ToCharArray();

            int minLenght = 0;
            if (firstArray.Length > secondArray.Length)
            {
                minLenght = secondArray.Length;
            }
            else if (firstArray.Length < secondArray.Length)
            {
                minLenght = firstArray.Length;
            }
            else
            {
                minLenght = firstArray.Length;
            }

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is lexicographically first");
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is lexicographically first");
                    break;
                }
                else if ((i == minLenght - 1 && firstArray.Length == secondArray.Length))
                {
                    Console.WriteLine("Both arrays are equal");
                }
                else if (i == minLenght - 1 && firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("The first array is lexicographically first");
                    break;
                }
                else if (i == minLenght - 1 && firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine("The second array is lexicographically first");
                    break;
                }
            }
        }
    }
}
