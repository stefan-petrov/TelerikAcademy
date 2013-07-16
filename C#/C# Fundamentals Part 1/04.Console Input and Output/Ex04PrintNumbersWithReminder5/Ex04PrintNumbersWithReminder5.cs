using System;

namespace Ex04PrintNumbersWithReminder5
{
    class Ex04PrintNumbersWithReminder5
    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNum = int.Parse(Console.ReadLine());

            int count = 0;

            if (firstNum <= secondNum)
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = secondNum; i <= firstNum; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("numbers between first and second number with reminder of the division by 5 = 0 are : " + count);
        }
    }
}
