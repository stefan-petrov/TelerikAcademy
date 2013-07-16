using System;

namespace Ex07GetNNumbersAndCalcSum
{
    class Ex07GetNNumbersAndCalcSum
    {
        static void Main()
        {
            Console.Write("Please enter the count of numbers you want to sum: ");
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal[] inputArray = new decimal[n];
            
            for (int i = 0; i < inputArray.Length; i++, n--)
            {
                Console.Write(" {0} -> ", n);
                decimal input = decimal.Parse(Console.ReadLine());
                inputArray[i] = input;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }
           
            Console.WriteLine("The sum of entered numbers is " + sum);
        }
    }
}
