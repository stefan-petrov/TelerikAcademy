using System;

namespace Ex04SortingValues
{
    class Ex04SortingValues
    {
        static void Main()
        {
            Console.WriteLine("Enter first real number");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second real number");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter third real number");
            decimal thirdNum = decimal.Parse(Console.ReadLine());

            if (firstNum >= secondNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine(firstNum);
                    if (secondNum >= thirdNum)
                    {
                        Console.WriteLine(secondNum);
                        Console.WriteLine(thirdNum);
                    }
                    else
                    {
                        Console.WriteLine(thirdNum);
                        Console.WriteLine(secondNum);
                    }
                }
                else
                {
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(firstNum);
                    Console.WriteLine(secondNum);
                }
            }
            else if (secondNum >= firstNum)
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine(secondNum);
                    if (firstNum >= thirdNum)
                    {
                        Console.WriteLine(firstNum);
                        Console.WriteLine(thirdNum);
                    }
                    else
                    {
                        Console.WriteLine(thirdNum);
                        Console.WriteLine(firstNum);
                    }
                }
                else
                {
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(secondNum);
                    Console.WriteLine(firstNum);
                }
            }
            else
            {
                Console.WriteLine(thirdNum);
                if (firstNum >= secondNum)
                {
                    Console.WriteLine(firstNum);
                    Console.WriteLine(secondNum);
                }
                else
                {
                    Console.WriteLine(secondNum);
                    Console.WriteLine(firstNum);
                }             
            }
        }
    }
}
