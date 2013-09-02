using System;

// Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

namespace Ex01SquareRoot
{
    class Ex01SquareRoot
    {
        static double SquareRoot(int num)
        {
            double result = Math.Sqrt(num);
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("SquareRoot of {0} is {1}", input, SquareRoot(input).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }   
    }
}
