using System;

namespace Ex02SignOfTheProduct
{
    class Ex02SignOfTheProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter first real number");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second real number");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter third real number");
            decimal thirdNum = decimal.Parse(Console.ReadLine());

            if (firstNum > 0 && secondNum > 0 && thirdNum > 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"+\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum < 0 && secondNum > 0 && thirdNum > 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"-\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum > 0 && secondNum < 0 && thirdNum > 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"-\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum > 0 && secondNum > 0 && thirdNum < 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"-\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum < 0 && secondNum < 0 && thirdNum > 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"+\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum < 0 && secondNum > 0 && thirdNum < 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"+\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum > 0 && secondNum < 0 && thirdNum < 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"+\"", firstNum, secondNum, thirdNum);
            }
            else if (firstNum < 0 && secondNum < 0 && thirdNum < 0)
            {
                Console.WriteLine("{0}*{1}*{2} is with sign \"-\"", firstNum, secondNum, thirdNum);
            }
        }
    }
}
