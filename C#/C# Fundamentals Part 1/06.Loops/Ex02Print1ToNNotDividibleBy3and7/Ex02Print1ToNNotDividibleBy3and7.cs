using System;

namespace Ex02Print1ToNNotDividibleBy3and7
{
    class Ex02Print1ToNNotDividibleBy3and7
    {
        static void Main()
        {
            Console.WriteLine("Please enter N");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
