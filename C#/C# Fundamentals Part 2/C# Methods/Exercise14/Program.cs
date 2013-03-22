using System;
using System.Collections.Generic;

namespace Exercise14
{
    class Program
    {
        static int CalcMinimum(params int[] elements)
        {
            int min = int.MaxValue;
            foreach (int num in elements)
            {
                if (num < min )
                {
                    min = num;
                }
            }
            return min;
        }

        static int CalcMaximum(params int[] elements)
        {
            int max = int.MinValue;
            
            foreach (int num in elements)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static int CalcAverage(params int[] elements)
        {
            int sum = 0;
            foreach (int num in elements)
            {
                sum += num;
            }
            sum = sum / elements.Length;
            return sum;
        }

        static int CalcSum(params int[] elements)
        {
            int sum = 0;
            foreach (int num in elements)
            {
                sum += num;
            }
            
            return sum;
        }

        static int CalcProduct(params int[] elements)
        {
            int product = 1;
            foreach (int num in elements)
            {              
                    product *= num;      
            }
            return product;
        }

        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The minimum of given numbers is : {0}", CalcMinimum( nums ));
            Console.WriteLine("The maximum of given numbers is : {0}", CalcMaximum(nums));
            Console.WriteLine("The average of given numbers is : {0}", CalcAverage(nums));
            Console.WriteLine("The sum of given numbers is : {0}", CalcSum(nums));
            Console.WriteLine("The product of given numbers is : {0}", CalcProduct(nums));

        }
    }
}
