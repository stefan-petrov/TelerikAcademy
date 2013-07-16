using System;

namespace Ex04CheckIfThirdDigitIs7
{
    class Ex04CheckIfThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            int last2DigitsRemoved = input / 100;
            bool thirdDigit = last2DigitsRemoved % 10 == 7;
            Console.WriteLine("The third digit is 7 ? {0}", thirdDigit);
        }
    }
}
