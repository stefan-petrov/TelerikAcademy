using System;

namespace Ex01Read3NumbersPrintTheirSum
{
    class ReadThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number");
            decimal thirdNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers you entered is : " + (firstNum + secondNum + thirdNum));
        }
    }
}
