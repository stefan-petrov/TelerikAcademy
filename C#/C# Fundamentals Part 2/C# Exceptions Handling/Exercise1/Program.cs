using System;
using System.Collections.Generic;




namespace Exercise1
{
    class Program
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
