using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program that reads two arrays from the console and compares them element by element.


namespace Ex02CompareTwoArrays
{
    class Ex02CompareTwoArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arrays' lenght: ");
            int arraylenght = int.Parse(Console.ReadLine());
            int[] array1 = new int[arraylenght];

            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("Array1 [{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            int[] array2 = new int[arraylenght];

            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("Array2 [{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < arraylenght; i++)
            {
                bool isSame = array1[i] == array2[i];
                Console.WriteLine("array1[{0}] - array2[{1}] Same ? : {2}", i, i, isSame);
            }
        }
    }
}
