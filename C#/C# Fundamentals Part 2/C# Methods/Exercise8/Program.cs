using System;
using System.Collections.Generic;

namespace Exercise8
{
    class Program
    {
        static List<int> AddIntegers(string num1, string num2)
        {
            char[] array1 = num1.ToCharArray();
            char[] array2 = num2.ToCharArray();
            
            int[] array1AsInt = new int[array1.Length];
            int[] array2AsInt = new int[array2.Length];
            int longestNum = Math.Max(array1.Length, array2.Length);
            int shortestNum = Math.Min(array1.Length, array2.Length);
            int[] result = new int[longestNum];
            
            List<int> resultList = new List<int>();
            
            
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

            bool remainder = false;
            for (int i = 0; i < shortestNum; i++)
            {
                if (remainder)
	            {
		             result[i] = array1AsInt[i] + array2AsInt[i] + 1;
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
                result[i] = array1AsInt[i] + array2AsInt[i];
                }

                if (result[i] > 9)
                {
                    result[i] = (array1AsInt[i] + array2AsInt[i]) % 10;
                    remainder = true;

                }
           
            }

            for (int i = shortestNum; i < longestNum; i++)
            {
                if (remainder == true && array1AsInt.Length > array2AsInt.Length)
                {
                    
                    result[i] = array1AsInt[i] + 1;
                    
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

                else if (remainder == true && array1AsInt.Length < array2AsInt.Length)
                {
                    
                    result[i] = array2AsInt[i] + 1;
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
                else if (remainder == false && array1AsInt.Length > array2AsInt.Length)
                {
                    result[i] = array1AsInt[i];
                }
                else if (remainder == false && array1AsInt.Length < array2AsInt.Length)
                {
                    result[i] = array2AsInt[i];
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

            foreach (var item in AddIntegers(input1 , input2) )
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
