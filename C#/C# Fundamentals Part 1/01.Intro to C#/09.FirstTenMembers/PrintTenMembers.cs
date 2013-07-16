using System;

namespace FirstTenMembers
{
    class PrintTenMembers
    {
        static void Main(string[] args)
        {
            int currentNumber = 2;
            Console.WriteLine(currentNumber);
            Console.WriteLine((++currentNumber) * (-1));
            Console.WriteLine((++currentNumber));
            Console.WriteLine((++currentNumber) * (-1));
            Console.WriteLine((++currentNumber));
            Console.WriteLine((++currentNumber) * (-1));
            Console.WriteLine((++currentNumber));
            Console.WriteLine((++currentNumber) * (-1));
            Console.WriteLine((++currentNumber));
            Console.WriteLine((++currentNumber) * (-1));
            Console.WriteLine((++currentNumber));

            // with for loop
            for (int i = 2; i <= 12; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i * (-1));
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
