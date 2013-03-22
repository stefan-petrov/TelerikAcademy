using System;
using System.Collections.Generic;

namespace Exercise13
{
    class Program
    {
        static string ReverseDigits(decimal num)
        {
            string numAsString = Convert.ToString(num);
            char[] numAsCharArray = numAsString.ToCharArray();
            char[] reversedCharArray = new char[numAsCharArray.Length];

            for (int i = 0; i < numAsCharArray.Length; i++)
            {
                reversedCharArray[numAsCharArray.Length - 1 - i] = numAsCharArray[i];
            }
        
            string reversedDigitsString = new string(reversedCharArray);
            return reversedDigitsString;
        
        }

        static decimal CalcAverage(params int[] elements)
        {
            decimal avg = 0;
            decimal sum = 0;
            foreach (int num in elements)
            {
                
                sum += num;
            }
            avg = sum / elements.Length;
            return avg;
        }

        static decimal SolveEquation(decimal a, decimal b)
        {
            decimal x = (b * (-1)) / a;
            return x;
        }

        static void Main()
        {
            
            Console.WriteLine("--------------------------");            
            Console.WriteLine("| Welcome to our sevices |");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("If You want to reverse a digit Enter 1");
            Console.WriteLine("If You want to calculate an average Enter 2");
            Console.WriteLine("If You want to solve an equation Enter 3");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.Write("Please enter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Please enter the decimal number to be reversed: ");
                decimal input = decimal.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    while (input<= 0)
                    {
                        Console.WriteLine("The decimal number should be non-negative");
                        Console.WriteLine("Please enter a non-negative decimal");
                        input = decimal.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("The number You have entered when reversed will look like this:");
                Console.WriteLine(ReverseDigits(input));
                Console.WriteLine("Thank You for using our services");
            }
            
            else if (choice == 2)
            {
                Console.WriteLine("Please enter the number of elements : ");
                int numElements = int.Parse(Console.ReadLine());
                int[] nums = new int[numElements];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = int.Parse(Console.ReadLine());
                }

                int counter = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    
                    if (nums[i] == 0)
                    {
                        counter++;
                        if (counter == nums.Length)
	                    {
		                      Console.WriteLine("The sequnence must not be empty !");
                        }
                    }
                }

                Console.WriteLine("The average of given numbers is : {0}", CalcAverage(nums));
                Console.WriteLine("Thank You for using our services");

            }
            
            else if (choice == 3)
            {
                Console.Write("Please enter value for a: ");
                decimal a = decimal.Parse(Console.ReadLine());
                if (a == 0)
                {
                    while (a == 0)
                    {
                        Console.WriteLine("\"a\" should not be equal to 0");
                        Console.WriteLine("Please enter new value for \"a\"");
                        a = decimal.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Please enter value for b: ");
                decimal b = decimal.Parse(Console.ReadLine());

                Console.WriteLine("X is equal to : {0}", SolveEquation( a , b));
                Console.WriteLine("Thank You for using our services");

            }

            else
            {               
                    Console.WriteLine("Invalid choice");
                    Main();
            }
        }
    }
}
