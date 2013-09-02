using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace Ex02ReadNumberMethod
{
    class Ex02ReadNumberMethod
    {
        static int ReadNumber(int start, int end)
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int counter = 10;
            while (counter > 0)
            {
                try
                {
                    int input = ReadNumber(start, end);
                    if (input < 1 || input > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you entered is out of the 1...100 range.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Non-numbered text.");
                }

                counter--;
            }
        }
    }
}
