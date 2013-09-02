using System;

// Write a method that return the maximal element in a portion of array of integers 
// starting at given index. Using it write another method that sorts an array in ascending / descending order.

namespace Ex09MaximalElement
{
    class Ex09MaximalElement
    {
        static int FindingMaximal(int[] num, int index)
        {
            int bigestNum = int.MinValue;
            int bigestNumIndex = 0;

            for (int i = index; i < num.Length; i++)
            {
                if (num[i] >= bigestNum)
                {
                    bigestNum = num[i];
                    bigestNumIndex = i;
                }
            }
            return bigestNumIndex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The maximal element on given portion is: ");
            Console.WriteLine(array[FindingMaximal(array, index)]);


            foreach (var item in SortingArrayDescending(array))
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            foreach (var item in SortingArrayAscending(array))
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

        }

        static int[] SortingArrayDescending(int[] someArray)
        {

            int[] theArray = new int[someArray.Length];
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = someArray[i];
            }


            for (int i = 0; i < theArray.Length; i++)
            {
                int tmpVal = theArray[i];
                theArray[i] = theArray[FindingMaximal(theArray, i)];
                theArray[FindingMaximal(theArray, i)] = tmpVal;
            }
            return theArray;
        }

        static int[] SortingArrayAscending(int[] someArray)
        {
            int[] theArray = new int[someArray.Length];

            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = someArray[i];
            }


            for (int i = 0; i < theArray.Length; i++)
            {
                int tmpVal = theArray[i];
                theArray[i] = theArray[FindingMaximal(theArray, i)];
                theArray[FindingMaximal(theArray, i)] = tmpVal;
            }

            Array.Reverse(theArray);
            return theArray;

        }
    }
}
