using System;
using System.Collections.Generic;

// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

namespace Ex08AddsPositiveIntegers
{
    class Ex08AddsPositiveIntegers
    {
        static List<int> AddIntegers(int[] array1, int[] array2)
        {           
            int longestNum = Math.Max(array1.Length, array2.Length);
            int shortestNum = Math.Min(array1.Length, array2.Length);
            int[] result = new int[longestNum];

            List<int> resultList = new List<int>();
         
            bool remainder = false;
            for (int i = 0; i < shortestNum; i++)
            {
                if (remainder)
                {
                    result[i] = array1[i] + array2[i] + 1;
                    if (result[i] > 9)
                    {
                        result[i] = result[i] % 10;
                        remainder = true;
                    }
                    else
                    {
                        remainder = false;
                    }
                }
                else
                {
                    result[i] = array1[i] + array2[i];
                }

                if (result[i] > 9)
                {
                    result[i] = (array1[i] + array2[i]) % 10;
                    remainder = true;
                }
            }

            for (int i = shortestNum; i < longestNum; i++)
            {
                if (remainder == true && array1.Length > array2.Length)
                {
                    result[i] = array1[i] + 1;

                    if (result[i] > 9)
                    {
                        result[i] = result[i] % 10;
                        remainder = true;
                    }
                    else
                    {
                        remainder = false;
                    }
                    if (result[longestNum - 1] > 9)
                    {
                        for (int k = 0; k < longestNum; k++)
                        {
                            resultList.Add(result[k]);
                        }
                        resultList.Add(1);
                    }
                }

                else if (remainder == true && array1.Length < array2.Length)
                {
                    result[i] = array1[i] + 1;
                    if (result[i] > 9)
                    {
                        result[i] = result[i] % 10;
                        remainder = true;
                    }
                    else
                    {
                        remainder = false;
                    }
                }
                else if (remainder == false && array1.Length > array2.Length)
                {
                    result[i] = array1[i];
                }
                else if (remainder == false && array1.Length < array2.Length)
                {
                    result[i] = array2[i];
                }
            }

            for (int k = 0; k < longestNum; k++)
            {
                resultList.Add(result[k]);
            }

            if (remainder)
            {
                resultList.Add(1);
            }

            resultList.Reverse();
            return resultList;
        }

        static void Main()
        {

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();

            int[] array1AsInt = new int[array1.Length];
            int[] array2AsInt = new int[array2.Length];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1AsInt[i] = Convert.ToInt32(new string(array1[i], 1));
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2AsInt[i] = Convert.ToInt32(new string(array2[i], 1));
            }
           
            Array.Reverse(array1AsInt);
            Array.Reverse(array2AsInt);

            foreach (var item in AddIntegers(array1AsInt, array2AsInt))
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
