using System;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first char array : ");
            string inputArray1 = Console.ReadLine();
            int input1Lenght = inputArray1.Length;

            char[] firstArray = inputArray1.ToCharArray() ;

            Console.Write("Enter the second char array : ");
            string inputArray2 = Console.ReadLine();
            int input2Lenght = inputArray1.Length;

            char[] secondArray = inputArray2.ToCharArray();

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
