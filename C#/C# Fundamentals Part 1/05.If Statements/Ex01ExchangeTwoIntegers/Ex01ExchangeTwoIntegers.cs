using System;

namespace Ex01ExchangeTwoIntegers
{
    class Ex01ExchangeTwoIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integer");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int secondInt = int.Parse(Console.ReadLine());

            if (firstInt >= secondInt)
            {
                if (firstInt == secondInt)
                {
                    Console.WriteLine("Both integers are equal");
                }
                else
                {
                    Console.WriteLine("First integer is bigger than second");
                }
            }
            else
            {
                Console.WriteLine("Second integer is bigger than first");
            }
        }
    }
}
