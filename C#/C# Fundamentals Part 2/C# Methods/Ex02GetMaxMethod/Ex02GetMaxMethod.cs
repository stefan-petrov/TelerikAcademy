using System;

// Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

namespace Ex02GetMaxMethod
{
    class Ex02GetMaxMethod
    {
        static void Main()
        {
            int integer1 = int.Parse(Console.ReadLine());
            int integer2 = int.Parse(Console.ReadLine());
            int integer3 = int.Parse(Console.ReadLine());

            int bigger = GetMax(integer1, integer2);           
            Console.WriteLine("The bigest of given integers is : {0}", GetMax(bigger, integer3));
        }

        static int GetMax(int int1, int int2)
        {
            if (int1.CompareTo(int2) > 0)
            {
                return int1;
            }            
            else
            {
                return int2;
            }
        }
    }
}
