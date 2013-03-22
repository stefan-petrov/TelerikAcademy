using System;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter arrays' lenght: ");
            int arraylenght = int.Parse(Console.ReadLine());
            int[] array1 = new int[arraylenght];

            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("Array1 [{0}]: ", i );
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
                Console.WriteLine("array1[{0}] - array2[{1}] Same ? : {2}", i, i,  isSame);
            }
        }
    }
}
