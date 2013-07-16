using System;

namespace Ex03MaxAndMinFromGivenNumbers
{
    class Ex03MaxAndMinFromGivenNumbers
    {
        static void Main()
        {
            Console.Write("Enter the count of the numbers you are going to enter: ");
            int numbersCount = int.Parse(Console.ReadLine());
            decimal[] numbers = new decimal[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = decimal.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("The biggest from the given numbers is: {0}", numbers[numbersCount-1]);
            Console.WriteLine("The smallest from the given numbers is: {0}", numbers[0]);
        }
    }
}
